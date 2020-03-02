using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace Prueba_de_DI_WFP
{
    public interface IA:ICommand,INotifyPropertyChanged
    {

        public void RaisePropertyChanged([CallerMemberName] string name = null);
    }
}
