   M S B A M L   `   `   `  ����C  ?MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MathGameMathGame  5   	       MathGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MathGame     5   	     � Title$  	Main Menu��5   	   $��500.43��6   $��598.209��6+    � 
ResizeMode$ CanMinimize=�6;   ��5	      �� 5
   
    �� ImageSource$# Images/MainMenuBackground.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ brdrMenuFrost��5      $��3q�6(   $
��Left=�6<   $	��300��6W   $��	90,84,0,0q�6d   $	��Top=�6w   $	��415��6�    �� CornerRadius$ 10��6�   ��5      �� 5       �� Color$ White��6"    �� Opacity$	 0.2Q�60   ��5      �� 5      $ White��6"   $	 0.8Q�60   ._�5      � .+�5      �� -   5         ��Name$ lblMainMenu��5      $��	Main Menu��6-   $��122,-9,125,255q�6A   $��28(�6Y   $��Showcard Gothic)�6g   
�������6�   �� 5      -   5        $��Music��5      $
��Left=�6+   $��
348,10,0,0q�6F   $	��Top=�6Z    d� 	IsChecked$
 TrueY�6r   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��RightToLeft=�6�   
�������$��Showcard Gothic)�6�   
 � 	Resources
 5       �� 
TargetType �� Property �� Value��%[   'F�       �� 5      " F�6    .�5      ��  � ��$ LeftToRight=�6>   5      5      5      �� 5      -   5        $ lblInfo��5      $&�� Welcome! Please input user info.��6)   $��
20,44,20,0q�6T   $	��Top=�6h   $��31��6�   $��18(�6�   $��Showcard Gothic)�6�   
�������$
��Thin"�6�   �� 5      -   5         ��Name$ btnAddition��5      $��Addition��6.   $
��Left=�6A   $��
243,89,0,0q�6\   $	��Top=�6p   $	��156��6�   $��2q�6�   ���	#FFFFFDFD$��42��6�   $��18(�6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   ��5      �� 5       $ 	#FFF57F7F��6*   ��5"      �� 5#      $ 	#FF37DC73��6*   $	 0.4Q�6<   5%      �� 5&      -   5        $ btnSubtraction��5&      $��Subtraction��61   $
��Left=�6G   $��243,136,0,0q�6b   $	��Top=�6w   $	��156��6�   $��2q�6�   ���	#FFFFFDFD$��42��6�   $��18(�6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   ��5'      �� 5(      $ 	#FFF57F7F��6*   ��5*      �� 5+      $ 	#FF37DC73��6*   $	 0.4Q�6<   5-      �� 5.      -   5        $ btnDivision��5.      $��Division��6.   $
��Left=�6A   $��243,183,0,0q�6\   $	��Top=�6q   $	��156��6�   $��2q�6�   ���	#FFFFFDFD$��41��6�   $��18(�6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   ��5/      �� 50      $ 	#FFF57F7F��6*   ��52      �� 53      $ 	#FF37DC73��6*   $	 0.4Q�6<   55      �� 56      -   5        $ btnMultiplication��56      $��Multiplication��64   $
��Left=�6M   $��243,229,0,0q�6h   $	��Top=�6}   $	��156��6�   $��2q�6�   ���	#FFFFFDFD$��41��6�   $��18(�6�   $��Segoe Script)�6�   $��	ExtraBold"�6  ��57      �� 58      $ 	#FFF57F7F��6*   ��5:      �� 5;      $ 	#FF37DC73��6*   $	 0.4Q�6<   5=      �� 5>      -	   5        $ btnUserInfo��5>      $��	User Info��6.   $
��Left=�6B   $��	10,89,0,0q�6]   $	��Top=�6p   $	��154��6�   $��2q�6�   ���	#FFFFFDFD$��42��6�   $��18(�6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   ��5?      �� 5@      $ 	#FFF57F7F��6*   ��5B      �� 5C      $ 	#FF37DC73��6*   $	 0.4Q�6<   5E      �� 5F      -
   5        $ btnHighScores��5F      $��High Scores��60   $
��Left=�6F   $��
10,229,0,0q�6a   $	��Top=�6u   $	��154��6�   $��2q�6�   ���	#FFFFFDFD$��41��6�   $��18(�6�   $��Segoe Script)�6�   $��	ExtraBold"�6�   ��5G      �� 5H      $ 	#FFF57F7F��6*   ��5J      �� 5K      $ 	#FF37DC73��6*   $	 0.4Q�6<   5M      5N      5O      5Q      5R      