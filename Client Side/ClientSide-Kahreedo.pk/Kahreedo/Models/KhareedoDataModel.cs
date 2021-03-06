﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


public partial class admin_Employee
{

    public admin_Employee()
    {

        this.admin_Login = new HashSet<admin_Login>();

    }


    public int EmpID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Nullable<int> Age { get; set; }

    public Nullable<System.DateTime> DateofBirth { get; set; }

    public string Gender { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string Mobile { get; set; }

    public string PhotoPath { get; set; }



    public virtual ICollection<admin_Login> admin_Login { get; set; }

}


public partial class admin_Login
{

    public int LoginID { get; set; }

    public int EmpID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<int> RoleType { get; set; }

    public string Notes { get; set; }



    public virtual admin_Employee admin_Employee { get; set; }

    public virtual Role Role { get; set; }

}


public partial class Category
{

    public Category()
    {

        this.genPromoRights = new HashSet<genPromoRight>();

        this.Products = new HashSet<Product>();

        this.SubCategories = new HashSet<SubCategory>();

    }


    public int CategoryID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Picture1 { get; set; }

    public string Picture2 { get; set; }

    public Nullable<bool> isActive { get; set; }



    public virtual ICollection<genPromoRight> genPromoRights { get; set; }

    public virtual ICollection<Product> Products { get; set; }

    public virtual ICollection<SubCategory> SubCategories { get; set; }

}


public partial class Customer
{

    public Customer()
    {

        this.Orders = new HashSet<Order>();

        this.RecentlyViews = new HashSet<RecentlyView>();

        this.Reviews = new HashSet<Review>();

        this.Wishlists = new HashSet<Wishlist>();

    }


    public int CustomerID { get; set; }

    public string First_Name { get; set; }

    public string Last_Name { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<int> Age { get; set; }

    public string Gender { get; set; }

    public Nullable<System.DateTime> DateofBirth { get; set; }

    public string Organization { get; set; }

    public string Country { get; set; }

    public string State { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string Email { get; set; }

    public string AltEmail { get; set; }

    public string Phone1 { get; set; }

    public string Phone2 { get; set; }

    public string Mobile1 { get; set; }

    public string Mobile2 { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Picture { get; set; }

    public string status { get; set; }

    public Nullable<System.DateTime> LastLogin { get; set; }

    public Nullable<System.DateTime> Created { get; set; }

    public string Notes { get; set; }



    public virtual ICollection<Order> Orders { get; set; }

    public virtual ICollection<RecentlyView> RecentlyViews { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }

    public virtual ICollection<Wishlist> Wishlists { get; set; }

}


public partial class genMainSlider
{

    public int MainSliderID { get; set; }

    public string ImageURL { get; set; }

    public string AltText { get; set; }

    public string OfferTag { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string BtnText { get; set; }

    public Nullable<bool> isDeleted { get; set; }

}


public partial class genPromoRight
{

    public int PromoRightID { get; set; }

    public int CategoryID { get; set; }

    public string ImageURL { get; set; }

    public string AltText { get; set; }

    public string OfferTag { get; set; }

    public string Title { get; set; }

    public Nullable<bool> isDeleted { get; set; }



    public virtual Category Category { get; set; }

}


public partial class Order
{

    public Order()
    {

        this.OrderDetails = new HashSet<OrderDetail>();

    }


    public int OrderID { get; set; }

    public int CustomerID { get; set; }

    public Nullable<int> PaymentID { get; set; }

    public Nullable<int> ShippingID { get; set; }

    public Nullable<int> Discount { get; set; }

    public Nullable<int> Taxes { get; set; }

    public Nullable<int> TotalAmount { get; set; }

    public Nullable<bool> isCompleted { get; set; }

    public Nullable<System.DateTime> OrderDate { get; set; }

    public Nullable<bool> DIspatched { get; set; }

    public Nullable<System.DateTime> DispatchedDate { get; set; }

    public Nullable<bool> Shipped { get; set; }

    public Nullable<System.DateTime> ShippingDate { get; set; }

    public Nullable<bool> Deliver { get; set; }

    public Nullable<System.DateTime> DeliveryDate { get; set; }

    public string Notes { get; set; }

    public Nullable<bool> CancelOrder { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual Payment Payment { get; set; }

    public virtual ShippingDetail ShippingDetail { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; }

}


public partial class OrderDetail
{

    public int OrderDetailsID { get; set; }

    public int OrderID { get; set; }

    public int ProductID { get; set; }

    public Nullable<decimal> UnitPrice { get; set; }

    public Nullable<int> Quantity { get; set; }

    public Nullable<decimal> Discount { get; set; }

    public Nullable<decimal> TotalAmount { get; set; }

    public Nullable<System.DateTime> OrderDate { get; set; }



    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }

}


public partial class Payment
{

    public Payment()
    {

        this.Orders = new HashSet<Order>();

    }


    public int PaymentID { get; set; }

    public int Type { get; set; }

    public Nullable<decimal> CreditAmount { get; set; }

    public Nullable<decimal> DebitAmount { get; set; }

    public Nullable<decimal> Balance { get; set; }

    public Nullable<System.DateTime> PaymentDateTime { get; set; }



    public virtual ICollection<Order> Orders { get; set; }

    public virtual PaymentType PaymentType { get; set; }

}


public partial class PaymentType
{

    public PaymentType()
    {

        this.Payments = new HashSet<Payment>();

    }


    public int PayTypeID { get; set; }

    public string TypeName { get; set; }

    public string Description { get; set; }



    public virtual ICollection<Payment> Payments { get; set; }

}


public partial class Product
{

    public Product()
    {

        this.OrderDetails = new HashSet<OrderDetail>();

        this.RecentlyViews = new HashSet<RecentlyView>();

        this.Reviews = new HashSet<Review>();

        this.Wishlists = new HashSet<Wishlist>();

    }


    public int ProductID { get; set; }

    public string Name { get; set; }

    public int SupplierID { get; set; }

    public int CategoryID { get; set; }

    public Nullable<int> SubCategoryID { get; set; }

    public string QuantityPerUnit { get; set; }

    public decimal UnitPrice { get; set; }

    public Nullable<decimal> OldPrice { get; set; }

    public string UnitWeight { get; set; }

    public string Size { get; set; }

    public Nullable<decimal> Discount { get; set; }

    public Nullable<int> UnitInStock { get; set; }

    public Nullable<int> UnitOnOrder { get; set; }

    public Nullable<bool> ProductAvailable { get; set; }

    public string ImageURL { get; set; }

    public string AltText { get; set; }

    public Nullable<bool> AddBadge { get; set; }

    public string OfferTitle { get; set; }

    public string OfferBadgeClass { get; set; }

    public string ShortDescription { get; set; }

    public string LongDescription { get; set; }

    public string Picture1 { get; set; }

    public string Picture2 { get; set; }

    public string Picture3 { get; set; }

    public string Picture4 { get; set; }

    public string Note { get; set; }



    public virtual Category Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    public virtual SubCategory SubCategory { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual ICollection<RecentlyView> RecentlyViews { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }

    public virtual ICollection<Wishlist> Wishlists { get; set; }

}


public partial class RecentlyView
{

    public int RViewID { get; set; }

    public int CustomerID { get; set; }

    public int ProductID { get; set; }

    public System.DateTime ViewDate { get; set; }

    public string Note { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual Product Product { get; set; }

}


public partial class Review
{

    public int ReviewID { get; set; }

    public Nullable<int> CustomerID { get; set; }

    public Nullable<int> ProductID { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Review1 { get; set; }

    public Nullable<int> Rate { get; set; }

    public Nullable<System.DateTime> DateTime { get; set; }

    public Nullable<bool> isDelete { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual Product Product { get; set; }

}


public partial class Role
{

    public Role()
    {

        this.admin_Login = new HashSet<admin_Login>();

    }


    public int RoleID { get; set; }

    public string RoleName { get; set; }

    public string Description { get; set; }



    public virtual ICollection<admin_Login> admin_Login { get; set; }

}


public partial class ShippingDetail
{

    public ShippingDetail()
    {

        this.Orders = new HashSet<Order>();

    }


    public int ShippingID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Mobile { get; set; }

    public string Address { get; set; }

    public string Province { get; set; }

    public string City { get; set; }

    public string PostCode { get; set; }



    public virtual ICollection<Order> Orders { get; set; }

}


public partial class SubCategory
{

    public SubCategory()
    {

        this.Products = new HashSet<Product>();

    }


    public int SubCategoryID { get; set; }

    public int CategoryID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Picture1 { get; set; }

    public string Picture2 { get; set; }

    public Nullable<bool> isActive { get; set; }



    public virtual Category Category { get; set; }

    public virtual ICollection<Product> Products { get; set; }

}


public partial class Supplier
{

    public Supplier()
    {

        this.Products = new HashSet<Product>();

    }


    public int SupplierID { get; set; }

    public string CompanyName { get; set; }

    public string ContactName { get; set; }

    public string ContactTitle { get; set; }

    public string Address { get; set; }

    public string Mobile { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public string Email { get; set; }

    public string City { get; set; }

    public string Country { get; set; }



    public virtual ICollection<Product> Products { get; set; }

}


public partial class sysdiagram
{

    public string name { get; set; }

    public int principal_id { get; set; }

    public int diagram_id { get; set; }

    public Nullable<int> version { get; set; }

    public byte[] definition { get; set; }

}


public partial class Wishlist
{

    public int WishlistID { get; set; }

    public int CustomerID { get; set; }

    public int ProductID { get; set; }

    public Nullable<bool> isActive { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual Product Product { get; set; }

}

