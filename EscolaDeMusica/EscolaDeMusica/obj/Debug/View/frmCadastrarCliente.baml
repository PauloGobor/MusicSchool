   M S B A M L   `   `   `  ����I  EEscolaDeMusica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EscolaDeMusica.ViewEscolaDeMusica.View  5   	   -    'EscolaDeMusica.View.frmCadastrarCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EscolaDeMusica.View     5   	     � Title$  frmCadastrarCliente��5   	   $��407.385��6%   $��780.612��66   ��5	      �� 5
   
    �� ImageSource$2 ,/EscolaDeMusica;component/Image/guitarra.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ TxtNome��5      $
��Left=�6#   $��27��6>   $��100,104,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��138��6�   $��0��6�   �� 5   
   -   5         ��Name$ lblNome��5      $��Nome:��6!   $
��Left=�61   $��27��6L   $��
10,104,0,0q�6X   $	��Top=�6l   $��85��6�   $��16(�6�   $
��Bold"�6�   ��5      �� 5       �� Color$ 	#FF20F023��6"   5      �� 5   
   -   5        $ lblCpf��5      $
��CPF:��6    $
��Left=�6/   $��27��6J   $��
10,156,0,0q�6V   $	��Top=�6j   $��85��6�   $��16(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.499,1.659&�6�   ���	#FF20F0236�   �� 5   
   -   5        $ TxtCpf��5      $
��Left=�6"   $��27��6=   $��100,156,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��138��6�   $��1��6�   �� 5   
   -   5         ��Name$ BtnCadastrarCliente��5      $��	Cadastrar��6.   $
��Left=�6B   $��204,279,0,0q�6]   $	��Top=�6r   $��93��6�   $ -0.786,0.539&�6�   $��32��6�   $��15(�6�   $��4��6�   ���	#FF20F023$��Segoe UI Semibold)�6  �� 5   
   -   5        $ BtnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��
44,279,0,0q�6T   $	��Top=�6h   $��93��6�   $ -0.786,0.539&�6�   $��32��6�   $��15(�6�   $��3��6�   ���	#FF050505���	#FF20F023$��Segoe UI Semibold)�6!  �� 5   
   -   5        $ label��5      $��CADASTRAR CLIENTE��6   $
��Left=�6;   $��	24,28,0,0q�6V   $	��Top=�6i   $	��273��6�   $
��Bold"�6�   $��25(�6�   ���	#FFD9FF006�   �� 5   
   -   5        $ lblSenhaCliente��5      $��Senha:��6)   $
��Left=�6:   $��27��6U   $��
10,211,0,0q�6a   $	��Top=�6u   $��85��6�   $��16(�6�   $
��Bold"�6�   $ 0.499,1.659&�6�   ���	#FF20F0236�   G� 5   
   -	   5        	 G�Name$	 psdSenhaCliente��5      $
��Left=�6/   $��27��6J   $��100,211,0,0q�6V   $	��Top=�6k   $	��138��6�   $��2��6�   5      5      