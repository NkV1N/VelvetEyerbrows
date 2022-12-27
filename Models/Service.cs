using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace VelvetEyrbrown.Models;

public partial class Service: INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private void notifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    private string? mainImagePath;
   
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Cost { get; set; }

    public int DurationInSeconds { get; set; }

    public string? Description { get; set; }

    public double? Discount { get; set; }

    public string? MainImagePath
    {
        get => mainImagePath;
        set
        {
            mainImagePath = value;
            notifyPropertyChanged(nameof(MainImagePath));
        }
    }
    public virtual ICollection<ServicePhoto> ServicePhotos { get; }
        = new ObservableCollection<ServicePhoto>();
    public virtual ICollection<ClientService> ClientServices { get; } = new List<ClientService>();
    public decimal CostWithDiscount
    {
        get
        {
            return Cost * (1 - (decimal)Discount);
        }
    }
    public decimal DurationInMinutes
    {
        get    
        {
            return DurationInSeconds / 60; 
        }
    }
    public int DiscountChanged
    {
        get
        {
            return (int)(Discount * 100);
        }
    } 
    
}
