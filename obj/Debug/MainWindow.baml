   M S B A M L   `   `   `  ????G  CFinalManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalManagerFinalManager  5   	   F BBookLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:BookLibrary;assembly=BookLibraryBookLibrary 5   	       FinalManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FinalManager     5   	   @data2.clr-namespace:BookLibrary;assembly=BookLibrary     5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)   .??5
      ? ???	#FF4FD7BD ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $	??45* ?6   ?? 5      $
??172* ?6   .+?5   
   ?? -   5         ??Name$ SortBy??5       ?? SelectedIndex$ 0??6#   $
??Left=?65   $??Center=?6P   $??35??6k   $??91??6w   $??49,0,0,0q?6?   $??16(?6?   ?? 5   
   -   5         ??Name$ CloseButton??5      $??Close??6&   $??18(?66   $??43,271,53,21q?6D   $??1??6Z   6g   ?? 5   
   -   5        $ 
MoveMovieP??5      $??Add Item??6%   $??1??68   $??22(?6H   $??2??6o   $??100,0,100,0q?6?   ?? 5   
   -   5        $ 
UpdateItem??5      $??Update??6%   $??18(?66   $??49,55,56,239q?6D   $??1??6Z   6g   ?? 5   
   -   5        $ 
DeleteItem??5      $??Delete??6%   $??18(?66   $??49,113,56,181q?6D   $??1??6[   6h   ?? 5   
   -   5        $ Report??5      $??Show discount??6!   $??13(?69   $??1??6G   $??49,177,56,117q?6T   6k   ?? 5   
   -   5         ??Name$ MyList??5      ???	#FF4FD7BD$??1??6[   $??2??6k   $??0,90,0,0q?6|   $??2??6?   ??6#   ??  ?? Source$ 1????5      ?? 5       ?? DataType  BookLibrary.Movie"  6   .R?5      ?? 	 ?? Orientation$	 Vertical=?6!   .+?5       ?? $	 
Horizontal=?6%   .+?5!      ?? $??Type: ??6(   68   ?? 5"      ??6(   ?? *Type+6@   5#      ?? 5$      $	 
Horizontal=?6%   .+?5%      ?? $??Name: ??6(   68   ?? 5&      ??6(   ?? *Name+6@   5'      ?? 5(      $	 
Horizontal=?6%   .+?5)      ?? $??Price: ??6(   69   ?? 5*      ??6(   ?? *
FinalPrice+6F   5+      ?? 5,      $	 
Horizontal=?6%   .+?5-      ?? $??Gener: ??6(   69   ?? 5.      ??6(   ?? *Geners+6B   5/      ?? 50      $	 
Horizontal=?6%   .+?51      ?? $??Description: ??6(   6?   ?? 52      ??6(   ?? *Description+6G   53      ?? 54      $	 
Horizontal=?6%   .+?55      ?? $??
Discount: ??6(   6<   ?? 56      ??6(   ?? *
Discount+6D   57      ?? 58      $	 
Horizontal=?6%   .+?59      ?? $??Stock: ??6(   69   ?? 5:      ??6(   ?? *Stock+6A   5;      ?? 5<      $	 
Horizontal=?6%   .+?5=      ?? $??	Created: ??6(   6;   ?? 5>      ??6(   ?? *	Created+6C   5?      ?? 5@      $	 
Horizontal=?6%   .+?5A      ?? $??ISBN: ??6(   68   ?? 5B      ??6(   ?? *ISBN+6@   5C      ?? 5D      .+?5E      ?? $?? ??6(   63   5F      5G      5H      5J      5K      5L      