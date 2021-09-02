using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftMvvmToolkitSourceGeneratorBug
{
    public partial class MainViewModel : ObservableObject
    {
        #region Properties

        [ObservableProperty]
        private int counter = 0;

        #endregion
    }
}
