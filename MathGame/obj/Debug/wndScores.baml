   M S B A M L   `   `   `  ����C  ?MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MathGameMathGame  5   	       MathGame.wndScores   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MathGame     5   	   -   5          � Title$  	wndScores��5   	   $��428.081��6   $��547.565��6,   ��5	      �� 5
   
    �� ImageSource$&  Images/HighSchoresBackground.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ brdrMenuFrost��5      $��3q�6(   $	��377��6<   $��198,10,10,0q�6I   $	��Top=�6^    �� CornerRadius$ 10��6v   ��5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.6Q�60   ��5      �� 5      $ White��6"   $	 0.8Q�60   ._�5      � -   5         �Name$ grdHighScores��5      .+�5      �� -   5         ��Name$ lblHighScoresTitle��5      $!��Multiplication High Scores!��64   $
��10,0q�6Z   $	��Top=�6h   $��16(�6�   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   �� 5      -   5        $ lblYourScore��5      $��Your Score:��6.   $
��Left=�6D   $��
10,331,0,0q�6_   $	��Top=�6s   $��16(�6�   $��Showcard Gothic)�6�   $	��306��6�   
�������6�   �� 5      -   5        $ lblFirstPlace��5      $-��'1.   Player   00   0/10   10/10   00:00��6/   $��
10,51,10,0q�6a   $	��Top=�6u   $��18(�6�   $��Showcard Gothic)�6�   ���	#FFFFDD04$��Center=�6�   $��Center=�6�   �� 5      -   5        $ lblSecondPlace��5      $.��(2.    Player   00   0/10   10/10   00:00��60   $��
10,86,10,0q�6c   $	��Top=�6w   $��Showcard Gothic)�6�   $��16(�6�   ���	#FFC4C8C9$��Center=�6�   $��Center=�6�   �� 5      -   5        $ lblThirdPlace��5      $/��)3.     Player   00   0/10   10/10   00:00��6/   $��10,116,10,0q�6c   $	��Top=�6x   $��14(�6�   $��Showcard Gothic)�6�   ���	#FFC97143$��Center=�6�   $��Center=�6�   �� 5      -	   5        $ lblFourthPlace��5      $0��*4.      Player   00   0/10   10/10   00:00��60   $��10,143,10,0q�6e   $	��Top=�6z   $��Showcard Gothic)�6�   $��Center=�6�   $��Center=�6�   
�������6�   �� 5      $4��.Place    Name    Age    Right    Wrong    Time��6   $��
10,26,10,0q�6Q   $	��Top=�6e   ���	#00000000$��Showcard Gothic)�6�   $��25��6�   $��14(�6�   
�������$��Center=�6�   $��Center=�6   �� 5      -
   5        $ lblFifthPlace��5      $0��*5.      Player   00   0/10   10/10   00:00��6/   $��10,168,10,0q�6d   $	��Top=�6y   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   �� 5      -   5        $ lblSixthPlace��5      $0��*6.      Player   00   0/10   10/10   00:00��6/   $��10,193,10,0q�6d   $	��Top=�6y   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   �� 5      -   5        $ lblSeventhPlace��5      $0��*7.      Player   00   0/10   10/10   00:00��61   $��10,219,10,0q�6f   $	��Top=�6{   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   �� 5      -   5        $ lblEighthPlace��5      $0��*8.      Player   00   0/10   10/10   00:00��60   $��10,245,10,0q�6e   $	��Top=�6z   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   �� 5       -   5        $ lblNinthPlace��5       $0��*9.      Player   00   0/10   10/10   00:00��6/   $��10,271,10,0q�6d   $	��Top=�6y   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   �� 5!      -   5        $ lblTenthPlace��5!      $1��+10.      Player   00   0/10   10/10   00:00��6/   $��10,297,10,0q�6e   $	��Top=�6z   $��Showcard Gothic)�6�   
�������$��Center=�6�   $��Center=�6�   5$      5%      �� 5&   
   -   5         ��Name$ btnScoresReturn��5&      $��	Main Menu��6*   $
��Left=�6>   $��
10,279,0,0q�6Y   $	��Top=�6m   $��85��6�   $��2q�6�   ���	#FFFFFDFD$��30��6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   	 �� 	IsDefault	 . 
���������5'      �� 5(      $ 	#FF290002��6"   $
 0.85Q�64   5*      �� 5+   
   -   5        $ btnScoresAddition��5+      $��Addition��6,   $
��Left=�6?   $��
10,314,0,0q�6Z   $	��Top=�6n   $��85��6�   $��2q�6�   ���	#FFFFFDFD$��30��6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   	 . 
���������5,      �� 5-      $ 	#FF290002��6"   $
 0.85Q�64   5/      �� 50   
   -   5        $ btnScoresSubtraction��50      $��Subtraction��6/   $
��Left=�6E   $��100,314,0,0q�6`   $	��Top=�6u   $��85��6�   $��2q�6�   ���	#FFFFFDFD$��30��6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   	 . 
���������51      �� 52      $ 	#FF290002��6"   $
 0.85Q�64   54      �� 55   
   -   5        $ btnScoresMultiplication��55      $��Multiplication��62   $
��Left=�6K   $��
10,349,0,0q�6f   $	��Top=�6z   $��85��6�   $��2q�6�   ���	#FFFFFDFD$��30��6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   	 . 
�������$��10(�6*  ��56      �� 57      $ 	#FF290002��6"   $
 0.85Q�64   59      �� 5:   
   -   5        $ btnScoresDivision��5:      $��Division��6,   $
��Left=�6?   $��100,349,0,0q�6Z   $	��Top=�6o   $��85��6�   $��2q�6�   ���	#FFFFFDFD$��30��6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   	 . 
���������5;      �� 5<      $ 	#FF290002��6"   $
 0.85Q�64   5>      5?      5@      