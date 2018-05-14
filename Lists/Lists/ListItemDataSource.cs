namespace Xamarin.Material.Samples.Lists
{
    class ListItemDataSource
    {
        static ListItem[] BuiltInItems = {
            new ListItem {
                PrimaryText = "PrimaryTextPrimaryTextPrimaryTextPrimaryText",
                AvatarText = 'A',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "PrimaryText PrimaryText PrimaryText PrimaryText",
                AvatarText = 'B',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text Primary Text Primary Text Primary Text",
                AvatarText = 'C',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'D',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'E',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'F',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'G',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'H',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'I',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'J',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'K',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'L',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'M',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'N',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'O',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'P',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'Q',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'R',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'S',
                IconId = Resource.Drawable.ic_android_black_24dp
            },
            new ListItem {
                PrimaryText = "Primary Text",
                AvatarText = 'T',
                IconId = Resource.Drawable.ic_android_black_24dp
            }
        };

        private ListItem[] _items;

        public int Count => _items.Length;

        public ListItemDataSource() => _items = ListItemDataSource.BuiltInItems;

        public ListItem this[int i] => _items[i];
    }
}