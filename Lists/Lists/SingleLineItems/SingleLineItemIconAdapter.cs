using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    class SingleLineItemIconAdapter : RecyclerView.Adapter
    { 
        public ListItemDataSource Items { get; private set; }

        public override int ItemCount => Items.Count;

        public SingleLineItemIconAdapter(ListItemDataSource items) => Items = items;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
                LayoutInflater
                    .From(parent.Context)
                    .Inflate(Resource.Layout.single_line_item_icon, parent, false);

            SingleLineItemIconViewHolder vh = new SingleLineItemIconViewHolder(itemView);

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SingleLineItemIconViewHolder vh = holder as SingleLineItemIconViewHolder;
            
            vh.PrimaryText.Text = Items[position].PrimaryText + $" #{(position + 1)}";
            vh.IconImage.SetImageResource(Items[position].IconId);
        }
    }
}