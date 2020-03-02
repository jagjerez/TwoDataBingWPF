#region ensamblado Microsoft.Practices.Prism, Version=4.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// C:\Users\josealejandro.godoy\Documents\CONTROL DE VERSIONES\abk\Desktop\ABK.Library\Prism\Microsoft.Practices.Prism.dll
#endregion

using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Microsoft.Practices.Prism.ViewModel
{
    //
    // Resumen:
    //     Base class for items that support property notification.
    //
    // Comentarios:
    //     This class provides basic support for implementing the System.ComponentModel.INotifyPropertyChanged
    //     interface and for marshalling execution to the UI thread.
    public abstract class NotificationObject : INotifyPropertyChanged
    {
        //protected NotificationObject();

        //
        // Resumen:
        //     Raised when a property on this object has a new value.
        public event PropertyChangedEventHandler PropertyChanged;

        //
        // Resumen:
        //     Raises this object's PropertyChanged event.
        //
        // Parámetros:
        //   propertyName:
        //     The property that has a new value.
        //protected virtual void RaisePropertyChanged(string propertyName);
        //
        // Resumen:
        //     Raises this object's PropertyChanged event for each of the properties.
        //
        // Parámetros:
        //   propertyNames:
        //     The properties that have a new value.
        //protected void RaisePropertyChanged(params string[] propertyNames);
        //
        // Resumen:
        //     Raises this object's PropertyChanged event.
        //
        // Parámetros:
        //   propertyExpression:
        //     A Lambda expression representing the property that has a new value.
        //
        // Parámetros de tipo:
        //   T:
        //     The type of the property that has a new value
        //protected void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression);
    }
}