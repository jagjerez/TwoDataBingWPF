
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace Prueba_de_DI_WFP
{
    public class MainWindowViewModel:A
    {

        private IServiceCollection Server { get; set; }
        public MainWindowViewModel(IServiceCollection services):base(services) {
            
            this.Server = services;
 
           

        }



    }
}
