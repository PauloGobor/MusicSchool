   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   )    #EscolaDeMusica.View.frmListarCursos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	     � Title$  frmListarCursos��5   	   $	��450��6!   $	��694��6.   ��5	      �� 5
   
    �� ImageSource$3 -/EscolaDeMusica;component/Image/partitura.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ 	btnFechar��5      $��Fechar��6$   $
��Left=�65   $��
20,355,0,0q�6P   $	��Top=�6d   $	��100��6|   $��27��6�   $��15(�6�   
�������$��Segoe UI Semibold)�6�   ��5      �� 5       �� Color$ 	#FF001FFF��6"    �� Opacity$
 0.94Q�64   5      �� 5   
   $��Lista de Cursos��6   $
��Left=�6*   $��	27,29,0,0q�6E   $	��Top=�6X   $	��194��6p   $��18(�6|   $
��Bold"�6�   ���	#FF001FFF6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dtaCursos��5         AutoGenerateColumns .  $
��Left=�6B   $��	40,85,0,0q�6]   $	��Top=�6p   $	��245��6�   $	��590��6�   ��5      �� 5      $ 	#FF080808��6"   $	 0.5Q�64      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Curso��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 110 64   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *Nome+  5      $ 	Professor��6%   $		 110 68   
 6D   �� *	Professor+  5      $ Vagas disp.��6%   $		 110 6:   
 6F   �� *
QtdVagas+  5      $ Valor��6%   $		 110 64   
 6A   �� *ValorMensal+  5      $	 Dia��6%   $		 110 62   
 6?   �� *DiaSemana.Nome+  5      $ 	Descricao��6%   $		 110 68   
 6E   �� *	Descricao+5      5!      5"      