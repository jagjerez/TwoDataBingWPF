using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Prueba_de_DI_WFP
{
    public class A : IA
    {
        private int _mensaje = 0;
        public int mensaje
        {
            get
            {
                return this._mensaje;
            }
            set
            {
                this._mensaje = value;
                RaisePropertyChanged("mensaje");
            }
        }

        private string _json = "";
        public string json
        {
            get
            {
                return this._json;
            }
            set
            {
                this._json = value;
                RaisePropertyChanged("json");
            }
        }

        private ICommand mConsolaWrite;

        public ICommand ConsolaWrite
        {
            get
            {
                if (mConsolaWrite == null)
                {
                    mConsolaWrite = this;
                }
                return mConsolaWrite;
            }
            set
            {
                mConsolaWrite = value;
            }
        }

        private string mtext = "Default";

        public string text
        {
            get
            {
                return mtext;
            }
            set
            {
                mtext = value;
                this.json = "{'property':"+ mtext +"}";
                RaisePropertyChanged("text");
                RaisePropertyChanged("json");
            }
        }


        public A(IServiceCollection services)
        {
            services.AddSingleton<IA, A>();


            this.ConsolaWrite.CanExecuteChanged += MConsolaWrite_CanExecuteChanged;
            //this.text.CanExecuteChanged += Text_CanExecuteChanged;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //this.json = "{" + String.Format("'hola':{0}", parameter) + "}";
            if(this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged?.Invoke(parameter, new EventArgs());
            }
           

        }

        public void RaisePropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void MConsolaWrite_CanExecuteChanged(object sender, EventArgs e)
        {
            this.mensaje += 1;
        }
    }
}
