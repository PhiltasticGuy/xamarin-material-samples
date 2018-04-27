using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    class SingleLineItemAdapter : RecyclerView.Adapter
    { 
        public ListItemDataSource Items { get; private set; }

        public override int ItemCount => Items.Count;

        public SingleLineItemAdapter(ListItemDataSource items) => Items = items;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
                LayoutInflater
                    .From(parent.Context)
                    .Inflate(Resource.Layout.single_line_item, parent, false);

            SingleLineItemViewHolder vh = new SingleLineItemViewHolder(itemView);

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SingleLineItemViewHolder vh = holder as SingleLineItemViewHolder;
            
            vh.PrimaryText.Text = Items[position].PrimaryText + $" #{(position + 1)}";
        }
    }
}