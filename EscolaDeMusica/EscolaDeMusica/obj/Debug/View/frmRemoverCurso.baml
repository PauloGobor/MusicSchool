   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   )    #EscolaDeMusica.View.frmRemoverCurso   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	     � Title$  Remover Curso��5   	   $	��450��6   $	��800��6,   ��5	      �� 5
   
    �� ImageSource$2 ,/EscolaDeMusica;component/Image/guitarra.jpg��6   .��5      � .+�5   
   �� $��Remover Curso��6   $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   $	��211��6n   $��18(�6z   $
��Bold"�6�   ���	#FF74FF00$��53��6�   �� 5   
   -   5         ��Name$ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��
10,385,0,0q�6T   $	��Top=�6h   $	��105��6�   $��15(�6�    J� RenderTransformOrigin$ 0.134,0.742&�6�   $��Segoe UI Black)�6�   $��2��6�   ��5      �� 5       �� Color$ 	#FFD9FF00��6"    �� Opacity$	 0.7Q�64   5      �� 5   
   -   5        $ 
btnRemover��5      $��Remover��6%   $
��Left=�67   $��677,385,0,0q�6R   $	��Top=�6g   $	��105��6   $��15(�6�   $��Segoe UI Black)�6�   $��3��6�   ��5      �� 5      $ 	#FFD9FF00��6"   $	 0.7Q�64   5      �� 5   
   $��Curso:��6   $
��Left=�6!   $��	27,68,0,0q�6<   $	��Top=�6O   $��60��6g   $��15(�6r   $
��Bold"�6�   ��5      �� 5      $ 	#FFD9FF00��6"   $	 0.5Q�64   5      �� 5   
   -   5         ��Name$ txtNomeCursoRemover��5      $
��Left=�6/   $��30��6J   $��
119,68,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��245��6�   $��15(�6�   $��0��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaCurso��5      $
��Left=�6%   $��
10,118,0,0q�6@   $	��Top=�6T   $��57��6l   $	��552��6x   ��5       �� 5!      $ 	#FF080808��6"   $	 0.5Q�64   	   Columns	 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Curso��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Nome+  5%      $
 	Professor��6%   $	 110 68    6D   �� *	Professor+  5&      $
 Vagas disp.��6%   $	 110 6:    6F   �� *
QtdVagas+  5'      $
 Valor��6%   $	 110 64    6A   �� *ValorMensal+  5(      $	
 Dia��6%   $	 110 62    6?   �� *DiaSemana.Nome+5*      �� 5+   
   -   5        $ 	btnBuscar��5+      $��Buscar��6$   $
��Left=�65   $��
412,68,0,0q�6P   $	��Top=�6d   $	��105��6|   $��15(�6�   $ 1.171,0.467&�6�   $��30��6�   $��Segoe UI Black)�6�   $��1��6�   ��5,      �� 5-      $ 	#FFD9FF00��6"   $	 0.7Q�64   5/      50      51      