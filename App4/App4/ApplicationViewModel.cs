using CounToastLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounToast
{
    public class ApplicationViewModel
    {
        public Factory Factory { get; set; } = new Factory();
        public Food SelectedFood { get; set; } = null;
    }
}
