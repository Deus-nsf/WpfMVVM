using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using CommunityToolkit.Mvvm.Input;
namespace WpfMVVM.DataBinding.ViewModels;


internal class LesControlesViewModel : INotifyPropertyChanged
{
	public string Test { get; set; }
	public ObservableCollection<string> Villes { get; set; } = new();


	public event PropertyChangedEventHandler? PropertyChanged;
	protected void OnPropertyChanged(string name)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}


	public LesControlesViewModel()
	{
		Test = "Hello";
	}


	public ICommand EditTest
	{
		get
		{
			return new RelayCommand(() =>
			{
				Test = "Pouet";
				OnPropertyChanged(nameof(Test));
			});
		}
	}

}
