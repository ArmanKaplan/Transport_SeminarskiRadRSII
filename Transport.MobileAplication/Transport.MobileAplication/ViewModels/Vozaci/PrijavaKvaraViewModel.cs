using System;
using System.Collections.Generic;
using System.Text;
using Transport.MobileAplication.ViewModels.Vozaci;

namespace Transport.MobileApplication.ViewModels.Vozaci
{
    public class PrijavaKvaraViewModel:BaseViewModel1
    {

        private Model.Voznje _voznja = new Model.Voznje();
        public Model.Voznje Voznja
        {
            get { return _voznja; }
            set { SetProperty(ref _voznja, value); }
        }
        private Model.Kvarovi _kvar = new Model.Kvarovi();
        public Model.Kvarovi Kvar
        {
            get { return _kvar; }
            set { SetProperty(ref _kvar, value); }
        }

    }
}
