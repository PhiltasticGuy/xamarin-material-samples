using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Util;
using System;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    [Activity(Label = "@string/single_line_items_label", MainLauncher=true, Theme = "@style/Theme.AppCompat.Light")]
    public class SingleLineItemsActivity : AppCompatActivity
    {
        private RecyclerView _recyclerView;
        private SingleLineItemAdapter _adapter;
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

                DividerItemDecoration dividerItemDecoration = 
                    new DividerItemDecoration(
                        _recyclerView.Context,
                        _layoutManager.Orientation
                    );
                _recyclerView.AddItemDecoration(dividerItemDecoration);

                _items = new ListItemDataSource();
                _adapter = new SingleLineItemAdapter(_items);

                _recyclerView.SetAdapter(_adapter);
            }
            catch (Exception ex)
            {
                Log.Debug("SingleLineItemActivity", ex.ToString());
            }
        }
    }
}