using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AdditionalClasses
{
    enum RecordType
    {
        Record = 0,
        String = 1,
        Short = 2,
        Integer = 3,
        Long = 4,
        Array = 5,
        Decimal = 6
    }

    public class Record
    {

        #region Field
        FileDescription _fileDiscription;
        internal int index;
        public int length;
        internal string _initValue;
        internal RecordType recordType;
        internal StringBuilder _value;
        Record _base;
        internal List<Record> listRecord = new List<Record>();
        Record inputRecord;
        #endregion //Field

        #region Property

        public virtual string Value
        {
            get
            {
                return Base._value.ToString(this.index, this.length);
            }
            set
            {
                string tmpValue = value;

                if (value.ToString().Length < this.length)
                {
                    tmpValue = tmpValue + new string(' ', this.length - tmpValue.Length);
                }

                this.Base._value = this.Base._value.Remove(this.index, this.length).Insert(this.index, tmpValue.Substring(0, this.length));
            }
        }

        internal Record Base
        {
            get
            {
                if (_base != this)
                {
                    return _base.Base;
                }

                return _base;
            }
        }

        #endregion //Property

        #region Constructor
        public Record()
        {
            index = 0;
            length = 0;
            _base = this;
            InitFilds();
        }


        public void InitFilds()
        {
            var list = GetAllFields(this.GetType()).ToList();

            foreach (FieldInfo item in list)
            {
                if (item != null)
                {
                    if (item.FieldType.BaseType.Name == "Array")
                    {
                        Add(item.GetValue(this) as Record[]);
                    }
                    else
                    {
                        Add(item.GetValue(this) as Record);
                    }
                }
            }

            Init();
        }

        public static IEnumerable<FieldInfo> GetAllFields(Type t)
        {
            if (t == null)
            {
                return Enumerable.Empty<FieldInfo>();
            }

            BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly;
            return t.GetFields(flags).Union(GetAllFields(t.BaseType));
        }
        public Record(int length)
        {
            this.length = length;
            this._value = new StringBuilder(new string(' ', length));
            this._base = this;
            InitFilds();
        }
        public Record(Record record)
        {
            inputRecord = record;
            InitFilds();
        }


        #endregion //Constructor

        #region Method

        public void Using(Record record)
        {
            _value = record._value;
        }


        public void Redefine(Record record)
        {
            this.Base._value.Remove(this.index, this.length);
            this.Base.length = this.Base.length - record.length;
            RedefineNext(this.index - record.index);
            RedefineChilde(this.index - record.index);
            this.index = record.index;
            this._base = record.Base;
        }

        public void RedefineNext(int dec)
        {
            foreach (Record recordNext in _base.listRecord.Where(item => _base.listRecord.IndexOf(item) > _base.listRecord.IndexOf(this)))
            {
                recordNext.index = recordNext.index - dec;
                recordNext.RedefineChilde(dec);
            }
        }

        public void RedefineChilde(int dec)
        {
            foreach (Record item in this.listRecord)
            {
                item.index = item.index - dec;
                item.RedefineChilde(dec);
            }
        }

        public void Add(Record record)
        {
            if (record != null)
            {
                listRecord.Add(record);
                record.UpdateChildeIndex(length - record.index);
                record.index = length;
                record._base = this._base;
                length = length + record.length;
            }
        }

        public void Add(Record[] recordArray)
        {
            foreach (Record record in recordArray)
            {
                Add(record);
            }
        }

        void UpdateChildeIndex(int inc)
        {
            foreach (Record rec in listRecord)
            {
                rec.index += inc;
                rec.UpdateChildeIndex(inc);
            }
        }


        public Record Redefine()
        {
            return new Record();
        }

        private void InitValue()
        {
            if (_initValue != null)
            {
                Value = _initValue;
            }

            if (listRecord.Count > 0)
                foreach (Record rec in listRecord)
                {
                    rec.InitValue();
                }
        }

        public void MoveZero()
        {
            Value = new string('0', length);
        }


        protected virtual void Init()
        {
            _value = new StringBuilder(new string(' ', length));
            InitializeChilde();
        }

        public virtual void Initialize()
        {
            if (_initValue != null)
            {
                this.Value = _initValue;
            }

            InitializeChilde();
        }

        internal void InitializeChilde()
        {
            foreach (Record rec in listRecord)
            {
                switch (rec.recordType)
                {
                    case RecordType.Integer:
                        (rec as IntField).Initialize();
                        break;

                    case RecordType.Long:
                        (rec as LongField).Initialize();
                        break;

                    case RecordType.String:
                        (rec as StrField).Initialize();
                        break;
                    case RecordType.Decimal:
                        (rec as DecimalField).Initialize();
                        break;

                    default:
                        rec.InitializeChilde();
                        break;
                }
            }
        }

        public void InitFileDiscription(FileDescription fileDiscription)
        {
            _fileDiscription = fileDiscription;
        }

        public void AttachFileDiscription(FileDescription fileDiscription)
        {
            _fileDiscription = fileDiscription;
        }

        public void Write()
        {
            //if (_fileDiscription != null)
            //{
            //_fileDiscription.Write();
            //}
        }

        public void Delete()
        {
            if (_fileDiscription != null)
            {
                _fileDiscription.Delete();
            }
        }

        public void Write(string value)
        {
            Value = value;

            //if (_fileDiscription != null)
            //{
            //_fileDiscription.Write();
            //}
        }

        public void SetRange(int position, int length, string _value)
        {
            Value = Value.Remove(position, length).Insert(position, _value);
        }

        public string GetRange(int position, int length)
        {
            return Value.Substring(position, length);
        }

        public void SetValue(string _property, object _value)
        {
            Record r = GetProperty(_property);
            if (r is IntField)
            {
                (r as IntField).Value = Convert.ToInt32(_value);
            }
            else if (r is LongField)
            {
                (r as LongField).Value = Convert.ToInt64(_value);
            }
            else
            {
                r.Value = _value.ToString();
            }
        }

        public Record GetProperty(string _property)
        {
            FieldInfo fi = GetType().GetField(_property);
            return fi == null ? null : (Record)fi.GetValue(this);
        }
        #endregion //Method
    }

    public class StrField : Record
    {
        #region Constructor
        public StrField()
        {
            recordType = RecordType.String;
        }

        public StrField(int length)
            : base(length)
        {
            recordType = RecordType.String;
        }

        public StrField(int length, string initValue)
            : base(length)
        {
            recordType = RecordType.String;
            _initValue = initValue;
            Value = initValue;
        }

        public new void Initialize()
        {
            if (_initValue != null)
            {
                this.Value = _initValue;
            }

            InitializeChilde();
        }
        #endregion

    }

    public class CharField : StrField
    {
        #region Constructor
        public CharField()
            : base(1)
        {
            recordType = RecordType.String;
        }


        public CharField(char initValue)
            : base(1)
        {
            recordType = RecordType.String;
            _initValue = Convert.ToString(initValue);
            Value = initValue;
        }
        #endregion

        public new char Value
        {
            get
            {
                return Convert.ToChar(base.Value);
            }
            set
            {
                base.Value = value.ToString();
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }


    public class IntField : Record
    {
        private string _format;
        private string Format;
        #region Property
        public new Int32 Value
        {
            get
            {
                return string.IsNullOrWhiteSpace(base.Value)?Value: Convert.ToInt32(base.Value);
            }
            set
            {
                int neededValue;
                string stringVal = value.ToString();
                if (value >= 0)
                {
                    if (stringVal.Length > length)
                    {
                        neededValue = Convert.ToInt32(stringVal.Substring(stringVal.Length - length));
                    }
                    else
                    {
                        neededValue = value;
                    }
                }
                else
                {
                    stringVal = stringVal.Substring(1);
                    if (stringVal.Length > length)
                    {
                        neededValue = Convert.ToInt32(stringVal.Substring(stringVal.Length - length)) * -1;
                    }
                    else
                    {
                        neededValue = value;
                    }
                }
                base.Value = neededValue.ToString(Format);
            }
        }

        public string StringValue
        {
            get
            {
                return Value.ToString(Format);
            }
            private set
            {

            }
        }

        #endregion

        #region Constructor
        public IntField()
        {
            recordType = RecordType.Integer;
        }

        public IntField(int length, bool signed = false)
            : base(length + (signed ? 1 : 0))
        {
            recordType = RecordType.Integer;
            _format = new string('0', length);
            Format = signed ? $"+{_format};-{_format};" : _format;
        }

        public IntField(int length, int initValue, bool signed = false)
            : base(length + (signed ? 1 : 0))
        {
            recordType = RecordType.Integer;
            _format = new string('0', length);
            Format = signed ? $"+{_format};-{_format};" : _format;
            _initValue = initValue.ToString(Format);
            Value = initValue;
        }
        #endregion

        #region Method
        public new void Init()
        {
            _value = new StringBuilder(new string('0', length));
            InitializeChilde();
        }

        public new void Initialize()
        {
            if (_initValue != null)
            {
                Value = Convert.ToInt32(_initValue);
            }
            else
            {
                Value = 0;
            }

            InitializeChilde();
        }

        public override string ToString()
        {
            return Value.ToString(_format);
        }

        #endregion
    }
    public class DecimalField : Record
    {
        private string _format;
        private string Format;
        #region Property
        public new Decimal Value
        {
            get
            {
                return Convert.ToDecimal(base.Value);
            }
            set
            {
                decimal neededValue;
                string stringVal = value.ToString();
                if (value >= 0)
                {
                    if (stringVal.Length > length)
                    {
                        neededValue = Convert.ToDecimal(stringVal.Substring(stringVal.Length - length));
                    }
                    else
                    {
                        neededValue = value;
                    }
                }
                else
                {
                    stringVal = stringVal.Substring(1);
                    if (stringVal.Length > length)
                    {
                        neededValue = Convert.ToDecimal(stringVal.Substring(stringVal.Length - length)) * -1;
                    }
                    else
                    {
                        neededValue = value;
                    }
                }
                base.Value = value.ToString(Format);
            }
        }

        public string StringValue
        {
            get
            {
                return Value.ToString(Format);
            }
            private set
            {

            }
        }

        #endregion

        #region Constructor
        public DecimalField()
        {
            recordType = RecordType.Decimal;
        }

        public DecimalField(int wholePart, int decimalPart, bool signed = false)
            : base(wholePart + decimalPart + (signed ? 2 : 1))
        {
            recordType = RecordType.Decimal;
            _format = new string('0', wholePart) + "." + new string('0', decimalPart);
            Format = signed ? $"+{_format};-{_format};" : _format;
        }

        public DecimalField(int wholePart, int decimalPart, decimal initValue, bool signed = false)
            : base(wholePart + decimalPart + (signed ? 2 : 1))
        {
            recordType = RecordType.Decimal;
            _format = new string('0', wholePart) + "." + new string('0', decimalPart);
            Format = signed ? $"+{_format};-{_format};" : _format;
            _initValue = initValue.ToString(Format);
            Value = initValue;
        }
        #endregion

        #region Method
        public new void Init()
        {
            _value = new StringBuilder(new string('0', length));
            InitializeChilde();
        }

        public new void Initialize()
        {
            if (_initValue != null)
            {
                Value = Convert.ToDecimal(_initValue);
            }
            else
            {
                Value = 0;
            }

            InitializeChilde();
        }

        public override string ToString()
        {
            return Value.ToString(_format);
        }
        #endregion
    }
    public class LongField : Record
    {
        private string _format;
        private string Format;
        #region Property
        public new Int64 Value
        {
            get
            {
                return Convert.ToInt64(base.Value);
            }
            set
            {
                long neededValue;
                string stringVal = value.ToString();
                if (value >= 0)
                {
                    if (stringVal.Length > length)
                    {
                        neededValue = Convert.ToInt64(stringVal.Substring(stringVal.Length - length));
                    }
                    else
                    {
                        neededValue = value;
                    }
                }
                else
                {
                    stringVal = stringVal.Substring(1);
                    if (stringVal.Length > length)
                    {
                        neededValue = Convert.ToInt64(stringVal.Substring(stringVal.Length - length)) * -1;
                    }
                    else
                    {
                        neededValue = value;
                    }
                }
                base.Value = value.ToString(Format);
            }
        }

        public string StringValue
        {
            get
            {
                return Value.ToString(Format);
            }
            private set
            {

            }
        }

        #endregion

        #region Constructor
        public LongField()
        {
            recordType = RecordType.Long;
        }

        public LongField(int length, bool signed = false)
            : base(length + (signed ? 1 : 0))
        {
            recordType = RecordType.Long;
            _format = new string('0', length);
            Format = signed ? $"+{_format};-{_format};" : _format;
        }

        public LongField(int length, Int64 initValue, bool signed = false)
            : base(length + (signed ? 1 : 0))
        {
            recordType = RecordType.Long;
            _format = new string('0', length);
            Format = signed ? $"+{_format};-{_format};" : _format;
            _initValue = initValue.ToString(Format);
            Value = initValue;
        }
        #endregion

        #region Method
        public new void Init()
        {
            _value = new StringBuilder(new string('0', length));
            InitializeChilde();
        }

        public new void Initialize()
        {
            if (_initValue != null)
            {
                Value = Convert.ToInt64(_initValue);
            }
            else
            {
                Value = 0;
            }

            InitializeChilde();
        }
        public override string ToString()
        {
            return Value.ToString(_format);
        }
        #endregion
    }
}