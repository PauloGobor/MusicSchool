   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   /    )EscolaDeMusica.View.frmRemoverInstrumento   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	     � Title$  frmRemoverInstrumento��5   	   $	��450��6'   $	��800��64   ��5	      �� 5
   
    �� ImageSource$2 ,/EscolaDeMusica;component/Image/guitarra.jpg��6   .��5      � .+�5   
   �� $��Remover Instrumento��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $	��239��6t   $��18(�6�   $
��Bold"�6�   ���	#FF74FF006�   �� 5   
   -   5         ��Name$ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��144,385,0,0q�6T   $	��Top=�6i   $	��105��6�   $��15(�6�    J� RenderTransformOrigin$ 0.134,0.742&�6�   $��Segoe UI Black)�6�   $��2��6�   ��5      �� 5       �� Color$ 	#FFD9FF00��6"    �� Opacity$	 0.7Q�64   5      �� 5   
   -   5        $ btnRemoverInstrumento��5      $��Remover��60   $
��Left=�6B   $��538,385,0,0q�6]   $	��Top=�6r   $	��105��6�   $��15(�6�   $��Segoe UI Black)�6�   $ 0.535,0.179&�6�   $��3��6�   ��5      �� 5      $ 	#FFD9FF00��6"   $	 0.7Q�64   5      �� 5   
   $��Curso:��6   $
��Left=�6!   $��	10,49,0,0q�6<   $	��Top=�6O   $��60��6g   $��15(�6r   $
��Bold"�6�   ��5      �� 5      $ 	#FFD9FF00��6"   $	 0.5Q�64   5      �� 5   
   -   5         ��Name$ txtNomeInstrumentoBuscar��5      $
��Left=�64   $��30��6O   $��	97,49,0,0q�6[    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��245��6�   $��15(�6�   $��0��6�   &   System.Windows.Controls.DataGrid  5   
   $
��Left=�6   $��	10,96,0,0q�6.   $	��Top=�6A   $��70��6Y   $	��601��6e   ��5       �� 5!      $ 	#FF080808��6"   $	 0.5Q�64      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Nome��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Nome+  5%      $	 Preco��6%   $	
 200 64    6@   �� *Preço+  5&      $	 
Quantidade��6%   $	
 200 69    6E   �� *
Quantidade+5(      �� 5)   
   -   5        $ btnBuscarInstrumento��5)      $��Buscar��6/   $
��Left=�6@   $��
385,49,0,0q�6[   $	��Top=�6o   $	��105��6�   $��15(�6�   $ 1.171,0.467&�6�   $��30��6�   $��Segoe UI Black)�6�   $��1��6  ��5*      �� 5+      $ 	#FFD9FF00��6"   $	 0.7Q�64   5-      5/      50      