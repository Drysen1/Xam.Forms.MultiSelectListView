using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MultiSelectApp.Models;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace MultiSelectApp.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        
        public HomeViewModel()
        {
            PopulateList();
        }

        //Field and property for Item.
        private ItemModel _item;
        public ItemModel Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }
            
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        //btnClick_Command
        public ICommand btnClick_Command
        {
            get
            {
                return new Command(() => {
                    IEnumerable<ItemModel> selectedItems = ItemList.Where(Item => Item.IsSelected == true);

                    int num = selectedItems.Count();

                    Message = "Total selected: " + num.ToString() + " ";

                    foreach(ItemModel item in selectedItems)
                    {
                        Message += item.Name + " ";
                    }
                });
            }
        }

        //Property and field for an obserable collection / List for item objects.
        private List<ItemModel> _itemList = new List<ItemModel>();
        public List<ItemModel> ItemList
        {
            get
            { return _itemList; }
            set
            {
                _itemList = value;
                OnPropertyChanged();
            }
        }

        //Mock data to populate the list with values.
        private void PopulateList()
        {
            ItemList.Add(new ItemModel
            {
                Name = "Name1",
                IsSelected = true //Lets start with one item selected shall we?
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name2",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name3",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name4",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name5",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name6",
                IsSelected = false
            });
            ItemList.Add(new ItemModel
            {
                Name = "Name7",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name8",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name9",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name10",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name11",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name12",
                IsSelected = false
            });
            //No number 13? :O 13 = bad luck :(
            ItemList.Add(new ItemModel
            {
                Name = "Name14",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name15",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name16",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name17",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name18",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name19",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name20",
                IsSelected = false
            });

            ItemList.Add(new ItemModel
            {
                Name = "Name21",
                IsSelected = false
            });
        }
        //Implementation of INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
