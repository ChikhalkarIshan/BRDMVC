using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace AdditionalClasses
{
    public class Compatibility
    {
        private Stack<Tuple<string, int>> PerformsEnds = new Stack<Tuple<string, int>>();
        private int currentInner = 0;
        private List<Tuple<string, int>> allMethods = new List<Tuple<string, int>>();
        private List<Tuple<string, int, int>> methodsQue = new List<Tuple<string, int, int>>() { new Tuple<string, int, int>("Main", 0, 0) };

        public void GetAllMethodsInfo(object caller)
        {
            var methods = caller.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Where(c => c.IsPrivate && !c.Name.Contains("ProcedureDivision"));
            foreach (MethodInfo mi in methods)
            {
                allMethods.Add(new Tuple<string, int>(mi.Name, mi.CustomAttributes.Count() > 0 ? Convert.ToInt32(mi.CustomAttributes.First().ConstructorArguments[0].Value) : 0));
            }
        }
        public void InitializeMethodsQueue()
        {
            foreach (Tuple<string, int> method in allMethods)
            {
                methodsQue.Add(new Tuple<string, int, int>(method.Item1, method.Item2, 0));
            }
        }

        public void PerformThru(object caller, string startMethod, string endMethod = null)
        {
            Tuple<string, int, int> clr = methodsQue[0];
            int maxValue = methodsQue.Count == 0 ? 0 : methodsQue.Max(c => c.Item3);
            methodsQue.RemoveAt(0);
            int startIndex = allMethods.FindIndex(c => c.Item1 == startMethod);
            int endIndex = -1;
            Tuple<string, int> method;
            if (endMethod != null)
            {
                method = allMethods.Where(c => c.Item1 == endMethod).First();
                PerformsEnds.Push(method);
                if (method.Item2 != 0)
                {
                    method = allMethods.Last(c => c.Item2 == method.Item2);
                    endIndex = allMethods.FindIndex(c => c.Item1 == method.Item1);
                }
                else
                {
                    endIndex = allMethods.FindIndex(c => c.Item1 == endMethod);
                }
            }
            else
            {
                method = allMethods.Where(c => c.Item1 == startMethod).First();
                if (method.Item2 != 0)
                {
                    method = allMethods.Last(c => c.Item2 == method.Item2);
                }
                endIndex = allMethods.FindIndex(c => c.Item1 == method.Item1);

            }

            currentInner = maxValue + 1;
            if (startIndex < 0)
            {
                throw new Exception($"There is no method {startMethod} in code.");
            }

            if (endIndex < 0)
            {
                throw new Exception($"There is no method {endMethod} in code.");
            }

            for (int i = endIndex; i >= startIndex; i--)
            {
                methodsQue.Insert(0, new Tuple<string, int, int>(allMethods[i].Item1, allMethods[i].Item2, currentInner));
            }
            CallNextMethod(caller);
            methodsQue.Insert(0, clr);
        }

        public void CallNextMethod(object caller, bool deleteCurrent = false)
        {
            if (deleteCurrent && methodsQue.Count > 0)
            {
                if (methodsQue[0].Item1 == allMethods[allMethods.Count - 1].Item1 && PerformsEnds.Count > 0 && PerformsEnds.Peek().Item1 != methodsQue[0].Item1)
                {
                    methodsQue.RemoveAll(c => c.Item1 != "EXIT" && c.Item3 != -1);
                }
                else if (PerformsEnds.Count > 0 && PerformsEnds.Peek().Item1 == methodsQue[0].Item1)
                {
                    methodsQue.RemoveAll(c => c.Item3 == currentInner);
                    currentInner--;
                    PerformsEnds.Pop();
                    return;
                }
                else
                {
                    methodsQue.RemoveAt(0);
                }
            }
            if (methodsQue.Count == 0)
                return;
            else if (methodsQue.Count == 1 && methodsQue[0].Item1 == "EXIT")
                caller.GetType().GetMethod("Exit").Invoke(caller, null);


            if (methodsQue.Max(c => c.Item3) == currentInner)
            {
                string nextMethod = methodsQue[0].Item1;
                caller.GetType().GetMethod(nextMethod, BindingFlags.NonPublic | BindingFlags.Instance).Invoke(caller, null);
            }
            else
            {
                currentInner--;
            }
        }

        public void GoTo(Action mark)
        {
            int count = 0;
            int maxInner = methodsQue.Max(t => t.Item3);
            int markIndex = allMethods.FindIndex(c => c.Item1 == mark.Method.Name);
            var med = methodsQue.FindLast(c => c.Item3 == maxInner);
            int lastInnerIndex = allMethods.FindIndex(t => t.Item1 == med.Item1 && t.Item2 == med.Item2);
            var furtherMethods = allMethods.Where(c => allMethods.IndexOf(c) >= allMethods.IndexOf(allMethods[markIndex]));

            if (markIndex > lastInnerIndex)
            {
                methodsQue.RemoveAll(c => c.Item3 == currentInner);
                foreach (var furtherMethod in furtherMethods)
                {
                    methodsQue.Insert(count, new Tuple<string, int, int>(furtherMethod.Item1, furtherMethod.Item2, maxInner));
                    count++;
                }
                methodsQue.Add(new Tuple<string, int, int>("EXIT", 0, -1));
            }
            else
            {
                methodsQue.RemoveAll(c => c.Item3 == currentInner);

                for (int i = lastInnerIndex; i >= markIndex; i--)
                {
                    methodsQue.Insert(0, new Tuple<string, int, int>(allMethods[i].Item1, allMethods[i].Item2, maxInner));
                }
            }
            mark();
        }

        public int IntegerOfDate(int coDate)
        {
            //converts a date in the Gregorian calendar from standard date form (YYYYMMDD) to integer date form
            if (coDate > 0)
            {
                coDate = Convert.ToInt32(
                             (DateTime.ParseExact(Convert.ToString(coDate).TrimStart('0'), "yyyyMMdd", CultureInfo.InvariantCulture) -
                              new DateTime(1600, 12, 31))
                             .TotalDays);
            }

            return coDate;
        }
    }

    public class SectionAttribute : Attribute
    {
        private int counter;
        private string sectionName;

        public SectionAttribute(int c)
        {
            this.counter = c;
        }

        public SectionAttribute(int c, string sn)
        {
            this.counter = c;
            this.sectionName = sn;
        }

        public virtual int Counter
        {
            get
            {
                return counter;
            }
        }
    }

    public class Helper
    {
        public static void Sort(Record[] array, string[] columns, string[] sorts)
        {
            bool change = false;
            Record buffer = new Record();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = 0; k < columns.Length; k++)
                    {
                        if (array[i].GetProperty(columns[k]) is StrField || array[i].GetProperty(columns[k]) is CharField)
                        {
                            if (string.Compare(array[i].GetProperty(columns[k]).Value, array[j].GetProperty(columns[k]).Value) > 0 && sorts[k] != "D")
                            {
                                change = true;
                                break;
                            }
                            else if (string.Compare(array[i].GetProperty(columns[k]).Value, array[j].GetProperty(columns[k]).Value) < 0)
                            {
                                change = false;
                                break;
                            }
                        }
                        else
                        {
                            if (Convert.ToDecimal(array[i].GetProperty(columns[k]).Value) > Convert.ToDecimal(array[j].GetProperty(columns[k]).Value) && sorts[k] != "D")
                            {
                                change = true;
                                break;
                            }
                            else if (Convert.ToDecimal(array[i].GetProperty(columns[k]).Value) < Convert.ToDecimal(array[j].GetProperty(columns[k]).Value))
                            {
                                change = false;
                                break;
                            }
                        }
                    }
                    if (change)
                    {
                        buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                    }
                }
            }
        }
    }

    class Method
    {
        public static void Call(object program, params object[] parameters)
        {
            var initializeMethod = program.GetType().GetMethod("Initialize");
            if (initializeMethod.GetParameters().Length > parameters.Length)
            {
                var neededMoreParameters = Enumerable.Repeat<object>(null, initializeMethod.GetParameters().Length - parameters.Length);
                var parametersList = parameters.ToList();
                parametersList.AddRange(neededMoreParameters);
                parameters = parametersList.ToArray();
            }
            initializeMethod.Invoke(program, parameters);
        }

        public static void Call(object program)
        {
            var initializeMethod = program.GetType().GetMethod("Initialize");
            initializeMethod.Invoke(program, null);
        }
    }
}