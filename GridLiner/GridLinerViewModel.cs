using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace GridLiner
{
    class GridLinerViewModel:BindableBase
    {

        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set { SetProperty(ref _ImagePath , value); }
        }

        public GridLinerViewModel()
        {}

        public GridLinerViewModel(string path)
        {
            this.ImagePath = path;
        }

    }
}
