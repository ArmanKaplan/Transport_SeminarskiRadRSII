using System;

using Transport.MobileAplication.Models.Vozaci;

namespace Transport.MobileAplication.ViewModels.Vozaci
{
    public class ItemDetailViewModel1 : BaseViewModel1
    {
        public Item1 Item { get; set; }
        public ItemDetailViewModel1(Item1 item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
