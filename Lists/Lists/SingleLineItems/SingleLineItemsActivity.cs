using Android.App;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Widget;
using System;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    [Activity(Label = "@string/single_line_items_label", MainLauncher=true, Theme = "@style/AppTheme")]
    public class SingleLineItemsActivity : AppCompatActivity
    {
        private RecyclerView _recyclerView;
        private RecyclerView.Adapter _adapter;
        private LinearLayoutManager _layoutManager;

        private ListItemDataSource _items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            try
            {
                SetContentView(Resource.Layout.single_line_item_main);

                _recyclerView = FindViewById<RecyclerView>(Resource.Id.rvSingleItems);
                _recyclerView.HasFixedSize = true;

                _layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
                _recyclerView.SetLayoutManager(_layoutManager);
                
                VerticalInnerDividerItemDecorator dividerItemDecoration = 
                    new VerticalInnerDividerItemDecorator(
                        ContextCompat.GetDrawable(_recyclerView.Context, Resource.Drawable.divider)
                    );
                _recyclerView.AddItemDecoration(dividerItemDecoration);

                _items = new ListItemDataSource();
                _adapter = new SingleLineItemAvatarActionAdapter(_items);

                if (_adapter as SingleLineItemAvatarActionAdapter != null)
                {
                    SingleLineItemAvatarActionAdapter adapter = _adapter as SingleLineItemAvatarActionAdapter;
                    adapter.ItemSecondaryActionClicked += OnItemSecondaryActionClicked;
                }

                _recyclerView.SetAdapter(_adapter);
            }
            catch (Exception ex)
            {
                Log.Debug("SingleLineItemActivity", ex.ToString());
            }
        }

        private void OnItemSecondaryActionClicked(object sender, int position)
        {
            // Perform Activity actions in response to event.
            Toast.MakeText(
                this, 
                $"Item #{(position + 1)} {(_items[position].IsChecked ? "liked" : "unliked")}!", 
                ToastLength.Short
            ).Show();
        }
    }
}