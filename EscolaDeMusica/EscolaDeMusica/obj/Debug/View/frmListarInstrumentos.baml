   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   /    )EscolaDeMusica.View.frmListarInstrumentos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	   -   5          � Title$  frmListarInstrumentos��5   	   $	��450��6'   $	��800��64   ��5	      �� 5
   
    �� ImageSource$3 -/EscolaDeMusica;component/Image/partitura.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ 	btnFechar��5      $��Fechar��6$   $
��Left=�65   $��
20,355,0,0q�6P   $	��Top=�6d   $	��100��6|   $��27��6�   $��15(�6�   
�������$��Segoe UI Semibold)�6�   ��5      �� 5       �� Color$ 	#FF001FFF��6"    �� Opacity$
 0.94Q�64   5      �� 5   
   $��Lista de Instrumentos��6   $
��Left=�60   $��	27,29,0,0q�6K   $	��Top=�6^   $	��194��6v   $��18(�6�   $
��Bold"�6�   ���	#FF001FFF6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaInstrumentos��5         AutoGenerateColumns .  $
��Left=�6H   $��	40,85,0,0q�6c   $	��Top=�6v   $	��245��6�   $	��590��6�   ��5      �� 5      $ 	#FF080808��6"   $	 0.5Q�64      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 200 63   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *Nome+  5      $ Preco��6%   $		 200 64   
 6@   �� *Preço+  5      $ 
Quantidade��6%   $		 200 69   
 6E   �� *
Quantidade+5      5      5      