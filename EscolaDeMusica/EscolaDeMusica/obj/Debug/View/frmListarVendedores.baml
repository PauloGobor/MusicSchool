   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   -    'EscolaDeMusica.View.frmListarVendedores   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	   -   5          � Title$  frmListarVendedores��5   	   $	��450��6%   $	��800��62   ��5	      �� 5
   
    �� ImageSource$3 -/EscolaDeMusica;component/Image/partitura.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ 	btnFechar��5      $��Fechar��6$   $
��Left=�65   $��
20,355,0,0q�6P   $	��Top=�6d   $	��100��6|   $��27��6�   $��15(�6�   
�������$��Segoe UI Semibold)�6�   ��5      �� 5       �� Color$ 	#FF001FFF��6"    �� Opacity$
 0.94Q�64   5      �� 5   
   $��Lista de Vendedores��6   $
��Left=�6.   $��	27,29,0,0q�6I   $	��Top=�6\   $	��194��6t   $��18(�6�   $
��Bold"�6�   ���	#FF001FFF6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaVendedores��5         AutoGenerateColumns .  $
��Left=�6F   $��	40,85,0,0q�6a   $	��Top=�6t   $	��245��6�   $	��590��6�   ��5      �� 5      $ 	#FF080808��6"   $	 0.5Q�64      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 200 63   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *Nome+  5      $	 CPF��6%   $		 200 62   
 6>   �� *Cpf+5      5      5      