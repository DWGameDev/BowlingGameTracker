   M S B A M L   `   `   `  ����K  GBowlingChallenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BowlingChallenge.ViewBowlingChallenge.View  5      G(clr-namespace:BowlingChallenge.ViewModelBowlingChallenge.ViewModel  5      !    BowlingChallenge.View.Board   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4view#clr-namespace:BowlingChallenge.View     5      >	viewmodel(clr-namespace:BowlingChallenge.ViewModel     5        � DataContext  5
      -  'BowlingChallenge.ViewModel.BoxViewModel  5   
   -   5        	ViewModel��5   !   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   ._�5      $   BowlingChallenge.View.ScoreBox  -   5          Name$
 Box1��5      $��Stretch=�6*     6H   �� *
FrameOne+ �� Mode$ OneWay=�5       �� 5!   
   $��2��6   ._�5"        -   5        $
 Box2��5"        6+   �� *
FrameTwo+5#      �� 5$   
   $��3��6   ._�5%        -   5        $
 Box3��5%        6+   �� *
FrameThree+5&      �� 5'   
   $��4��6   ._�5(        -   5        $
 Box4��5(        6+   �� *	FrameFour+5)      �� 5*   
   $��5��6   ._�5+        -   5        $
 Box5��5+        6+   �� *	FrameFive+5,      �� 5-   
   $��6��6   ._�5.        -   5        $
 Box6��5.        6+   �� *
FrameSix+5/      �� 50   
   $��7��6   ._�51        -   5        $
 Box7��51        6+   �� *
FrameSeven+52      �� 53   
   $��8��6   ._�54        -	   5        $
 Box8��54        6+   �� *
FrameEight+55      �� 56   
   $��9��6   ._�57        -
   5        $
 Box9��57        6+   �� *	FrameNine+58      �� 59   
   $��10��6   ._�5:        -   5        $ 
TenthFrame��5:      $��9��60   $��72��6@     6K   �� *
FrameTen+5;      5=      5>      