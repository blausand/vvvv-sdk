using System;
using System.Collections.Generic;
using System.Text;

namespace VVVV.TodoMap.Lib.Modules.Osc
{
    public class TodoOscInput : AbstractTodoInput
    {
        private TodoOscDevice dev;

        public TodoOscInput()
            : base()
        { 
            this.InputSlice = "0";
        }

        public void SetDevice(TodoOscDevice dev)
        {
            this.dev = dev;
        }

        public override string Device
        {
            get
            {
                return "Any";
            }
            set
            {
                //base.Device = value;
            }
        }


        public string Message { get; set; }

        public override string InputType
        {
            get { return "OSC"; }
        }

        public override string InputMap
        {
            get
            {
                return this.Message;
            }
        }

        public int Slice { get; set; }
        //mnb: the slice(s) of incoming OSC bundle 
        public override string InputSlice
        {
            get
            {
                return this.Slice.ToString();
            }
            set
            {
                this.Slice = Convert.ToInt32(value);
                //mnb: Add validation here and 
                // callback UI with this.Slice.toString()
            }
        }

        public TodoOscInput(TodoVariable var)
            : base(var)
        {

        }

        /*
        public void UpdateValue(double val)
        {
            this.Variable.SetValue(this, val);
        }*/

    }
}
