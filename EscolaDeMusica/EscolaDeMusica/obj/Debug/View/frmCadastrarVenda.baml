   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   +    %EscolaDeMusica.View.frmCadastrarVenda   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	   -   5          � Title$  frmCadastrarVenda��5   	   $	��450��6#   $	��800��60   ��5	      �� 5
   
    �� ImageSource$= 7/EscolaDeMusica;component/Image/582x0_519ed740ae826.jpg��6   .��5      � .+�5   
   �� $��Cadastrar Venda��6   $
��Left=�6*   $��	24,28,0,0q�6E   $	��Top=�6X   $	��273��6p   $
��Bold"�6|   $��25(�6�   ���	#FFD9FF006�   �� 5   
   $��CPF Cliente:��6   $
��Left=�6'   $��
23,172,0,0q�6B   $	��Top=�6V   $	��109��6n   $��16(�6z   $
��Bold"�6�   $��30��6�   ���	#FFD9FF006�   �� 5   
   $��CPF Vendedor:��6   $
��Left=�6(   $��
12,207,0,0q�6C   $	��Top=�6W   $	��122��6o   $��16(�6{   $
��Bold"�6�   $��30��6�   ���	#FFD9FF006�   �� 5   
   -   5         ��Name$ txtClienteCpf��5      $
��Left=�6)   $��30��6D   $��137,172,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��167��6�   $��0��6�   �� 5   
   -   5        $ txtVendedorCpf��5      $
��Left=�6*   $��30��6E   $��137,207,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��167��6�   $��1��6�   �� 5   
   -   5         ��Name$ btnCadastrarVenda��5      $��	Cadastrar��6,   $
��Left=�6@   $��673,378,0,0q�6[   $	��Top=�6p   $	��111��6�   $��32��6�   $��15(�6�   $��5��6�   ���	#FFD9FF00��5      �� 5       �� Color$ 	#FF0B0B0B��6"    �� Opacity$	 0.5Q�64   5      �� 5   
   -   5        $��Cancelar��5      $
��Left=�6$   $��579,378,0,0q�6?   $	��Top=�6T   $��73��6l    J� RenderTransformOrigin$ -0.786,0.539&�6w   $��32��6�   $��15(�6�   $��4��6�   ���	#FFD9FF00��5      �� 5      $ 	#FF0B0B0B��6"   $	 0.5Q�64   5      �� 5   
   $��Quantidade:��6   $
��Left=�6&   $��
12,277,0,0q�6A   $	��Top=�6U   $��30��6m   $	��170��6y   $��16(�6�   $
��Bold"�6�   ���	#FFD9FF006�   �� 5   
   $��Instrumento:��6   $
��Left=�6'   $��
12,242,0,0q�6B   $	��Top=�6V   $	��170��6n   $��16(�6z   $
��Bold"�6�   $��30��6�   ���	#FFD9FF006�   �� 5   
   -   5        $ txtQuantidadeInstrumento��5      $
��Left=�64   $��30��6O   $��137,277,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��167��6�   $��2��6�   �� 5   
   -   5         ��Name$ cbInstrumentos��5      $
��Left=�6+   $��137,242,0,0q�6F   $	��Top=�6[   $	��167��6s   $��30��6   �� 5    
   -   5        $ btnAdicionarItemVenda��5       $��	Adicionar��60   $
��Left=�6D   $��137,378,0,0q�6_   $	��Top=�6t   $	��167��6�   $��32��6�   $��15(�6�   $��3��6�   ���	#FFD9FF00��5!      �� 5"      $ 	#FF0B0B0B��6"   $	 0.5Q�64   5$      &   System.Windows.Controls.DataGrid  5%   
   -	   5        	  Name$	 	dtaVendas��5%      
   AutoGenerateColumns
 .  $
��Left=�6B   $	��135��6]   $��316,172,0,0q�6j   $	��Top=�6   $	��468��6�      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Instrumento��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 5(   #   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6/   �� *Instrumento.Nome+  5)      $ 
Quantidade��6%   $	 120 5*   #    6/   �� *
Quantidade+  5+      $ Preço��6%   $	 140 5,   #    6/   �� *Instrumento.Preço+  5.      $ Subtotal��6%   $	 120 5/   #    6/   �� *
Subtotal+52      �� 53   
   -
   5         ��Name$ lblTotal��53      $�� ��6"   $
��Left=�6-   $��316,336,0,0q�6H   $	��Top=�6]   $	��197��6u   ���	#FFEA1313$��20(�6�   $
��Bold"�6�   54      55      