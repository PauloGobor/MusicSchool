   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   *    $EscolaDeMusica.View.frmAlunoPorCurso   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	   -   5          � Title$  frmAlunoPorCurso��5   	   $��393.458��6"   $��654.207��63   .��5	      � ��5
   
   �� 5       �� ImageSource$2 ,/EscolaDeMusica;component/Image/guitarra.jpg��6   .+�5   
   �� -   5         ��Name$ label��5      $��Curso:��6   $
��Left=�60   $��	10,10,0,0q�6K   $	��Top=�6^   ���	#FFFDFDFD6v   �� 5   
   -   5         ��Name$ btnBuscaCurso��5      $��Buscar��6(   $
��Left=�69   $��
226,16,0,0q�6T   $	��Top=�6h   $��75��6�   $��0��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dtaAlunos��5      $��Center=�6&      AutoGenerateColumns .  $��
76,86,52,0q�6_   $	��Top=�6s   $	��198��6�   $	��518��6�   ��5      �� 5       �� Color$ 	#FF080808��6"    �� Opacity$	 0.5Q�64      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nº Matrícula��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *IdMatricula+  5      $
	 Nome��6%   $	
 100 5   %    61   �� *
Aluno.Nome+  5      $		 CPF��6%   $	
 100 5   %    61   �� *	Aluno.Cpf+  5      $	 
Nascimento��6%   $	
 100 5   %    61   �� *Aluno.Nascimento+  5      $	 Telefone��6%   $	
 100 5   %    61   �� *Aluno.Telefone+5      �� 5    
   -   5        $ 	btnFechar��5       $��Fechar��6$   $��Center=�65   $��212,332,360,0q�6R   $	��Top=�6i   $��74��6�   $��2��6�   �� 5!   
   -   5        $ button��5!      $��Limpar��6!   $
��Left=�62   $��349,333,0,0q�6M   $	��Top=�6b   $��75��6z   $��1��6�   �� 5"   
   -   5         ��Name$ 	cboCursos��5"      $
��Left=�6&   $��	70,14,0,0q�6A   $	��Top=�6T   $	��120��6l   5$      5%      