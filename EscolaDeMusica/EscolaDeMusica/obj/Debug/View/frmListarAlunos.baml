   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   )    #EscolaDeMusica.View.frmListarAlunos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	   -   5          � Title$  frmListarAlunos��5   	   $	��450��6!   $	��800��6.   ��5	      �� 5
   
    �� ImageSource$3 -/EscolaDeMusica;component/Image/partitura.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ 	btnFechar��5      $��Fechar��6$   $
��Left=�65   $��
20,355,0,0q�6P   $	��Top=�6d   $	��100��6|   $��27��6�   $��15(�6�   
�������$��Segoe UI Semibold)�6�   ��5      �� 5       �� Color$ 	#FF001FFF��6"    �� Opacity$
 0.94Q�64   5      �� 5   
   $��Lista de Alunos��6   $
��Left=�6*   $��	27,29,0,0q�6E   $	��Top=�6X   $	��194��6p   $��18(�6|   $
��Bold"�6�   ���	#FF001FFF6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dtaAlunos��5         AutoGenerateColumns .  $
��Left=�6B   $��	40,85,0,0q�6]   $	��Top=�6p   $	��245��6�   $	��679��6�    � ForceCursor .  J� SnapsToDevicePixels . ��5      �� 5      $ 	#FF080808��6"   $	 0.5Q�64   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Nome��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 190 5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Nome+  5      $	
 CPF��6%   $	 190 5   %    61   �� *Cpf+  5      $
 
Nascimento��6%   $	 190 5   %    61   �� *
Nascimento+  5      $
 Telefone��6%   $	 190 5   %    61   �� *
Telefone+5!      5"      5#      