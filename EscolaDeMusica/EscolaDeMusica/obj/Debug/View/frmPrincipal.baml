   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   &     EscolaDeMusica.View.frmPrincipal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	     � Title$  frmPrincipal��5   	   $��488.594��6   $��788.376��6/   .��5	      � -   5         �Name$ grdPrincipal��5	      $��0,-33,0,-0.4q�6!   $
��Left=�67   $	��497��6R   $
��Auto=�6^    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   o� -   5         o�Name$
 menu��5      $
��Left=�6   $��51��68   $	��Top=�6D   $	��782��6\   $��0,78,-285.2,0q�6h   .@�5      m� $��Aluno��6   $��50��6&   $	��101��62   $��20(�6>   ���	#FF0096FF$
��Bold"�6c   $��Comic Sans MS)�6u   ���	#FFCBFF00
���   �$��Center=�6�   $��Center=�6�   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�   .@�5      m� -   5        $��Fazer Login��5      $
��Left=�60   $	��235��6K   $��16(�6W   $��
0,0,-0.8,0q�6e   $��30��6y   ���	#FF00FFC86�   m� 5      -   5        $��Fazer Cadastro��5      $
��Left=�63   $	��235��6N   $��30��6Z   $��16(�6f   ���	#FF00FFC86�   m� 5      -   5        $��Listar Alunos��5      $
��Left=�62   $	��235��6M   $��30��6Y   $��16(�6e   ���	#FF00FFC86�   5      m� 5      $��Cursos��6   $��50��6'   $��96��63   $��20(�6>   ���	#FF0096FF$
��Bold"�6c   $��RightToLeft=�6u   $��Comic Sans MS)�6�   ���	#FFCBFF00
���   �$��Center=�6�   $��Center=�6�   .@�5      m� -   5        $��Listar Cursos��5      $
��Left=�62   $	��220��6M   $��30��6Y   ���	#FF00FFC8$��	0,0,-44,0q�6�   m� 5      -   5        $��Listar Alunos��5      $
��Left=�62   $	��220��6M   $��30��6Y   ���	#FF00FFC8$��	0,0,-44,0q�6�   5      m� 5      $��Cliente��6   $��51��6(   $	��113��64   $��20(�6@   ���	#FF0096FF$��Comic Sans MS)�6e   $
��Bold"�6�   ���	#FFCBFF00.@�5      m� -   5        $��Fazer Cadastro��5      $
��Left=�63   ���	#FF00FFC8$��30��6e   $	��247��6q   $��-13,0,-51.6,0q�6�   5      m� 5      $��	_Vendedor��6   $��50��6*   $	��126��66   $��20(�6B   ���	#FF0096FF$
��Bold"�6g   $��RightToLeft=�6y   $��Comic Sans MS)�6�   ���	#FFCBFF00
���   �.@�5      m� -	   5        $��Fazer Login��5      $
��Left=�60   $	��236��6K   $��30��6W   $��0,0,-25.8,0q�6c   $��16(�6x   ���	#FF00FFC86�   m� 5      -
   5        $��Listar Vendedores��5      $
��Left=�66   $	��251��6Q   $��30��6]   $��16(�6i   $��-14,0,-20.2,0q�6w   ���	#FF00FFC86�   5       m� 5!      $��Instrumentos��6   $��20(�6-   $��50��6;   $	��180��6G   ���	#FF0096FF$
��Bold"�6j   $��RightToLeft=�6|   $��Comic Sans MS)�6�   ���	#FFCBFF00
���   �.@�5"      m� -   5        $��Instrumentos Disponíveis��5"      $
��Left=�6=   $	��331��6X   ���	#FF00FFC8$��-32,0,-10.2,0q�6�   $��20(�6�   5#      m� 5$      $��Administrador��6   $��20(�6.   $��50��6<   $	��165��6H   ���	#FF0096FF$
��Bold"�6k   $��RightToLeft=�6}   $��Comic Sans MS)�6�   ���	#FFCBFF00
���   �.@�5%      m� -   5        $��Fazer Login��5%      $��Right=�60   ���	#FF00FFC8$��30��6c   $	��197��6o   $��-15,0,0.4,0q�6�   5&      5'      �� 5(   
   -   5         ��Name$ label��5(      $ ��BEM VINDO A ESCOLA DO ROCK��6   $��Center=�6D   $��45��6a   $��0,33,-285.2,0q�6m   $	��Top=�6�   $	��782��6�   $��30(�6�   $��	ExtraBold"�6�   $��Italic$�6�   $��Center=�6�   ��5)      �� 5*       �� ImageSource$0 */EscolaDeMusica;component/Image/musica.png��6    j� Stretch$ UniformToFill=�6V   5,      �� 5-   
   -   5        	 ��Name$	 	Principal��5-   G   $3��-/EscolaDeMusica;component/Image/Principal.jpg��6   $	��363��6Z   $��0,130,-285.2,-0.2q�6g   $	��Top=�6�   

 � Tag$
 	Principal��6�    � OverridesDefaultStyle . $��Center=�6�   $	��250��6�   $	��782��6�   $��Uniform=�6   5/      50      