   M S B A M L   `   `   `  ����K  GBowlingChallenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BowlingChallenge.ViewBowlingChallenge.View  5      G(clr-namespace:BowlingChallenge.ViewModelBowlingChallenge.ViewModel  5      ?$clr-namespace:BowlingChallenge.ModelBowlingChallenge.Model  5      3clr-namespace:BowlingChallengeBowlingChallenge  5	      $    BowlingChallenge.View.ScoreBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:BowlingChallenge.View     5      >	viewmodel(clr-namespace:BowlingChallenge.ViewModel     5      6model$clr-namespace:BowlingChallenge.Model     5      ;BowlingChallengeclr-namespace:BowlingChallenge     5	      -   5          >�Name$  Frame��5   6   .��5      � 
������� � RowDefinitions 5      �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5      �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5      �� -   5         ��Name$ S1��5   )   $��0��6   $��0��6   $��10(�65   $��Center=�6C   $��Center=�6e    �� TextAlignment$ Center=�5      $��24��6   $��40��6(   
������� �� CharacterCasing$ Upper=�6^   ��64   Z� ��6v   �� *
FirstScore+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   -   5        $ S2��5   /   $��1��6   $��0��6"   $��10(�6;   $��Center=�6I   $
��Left=�6k   $ Center=�5      $��24��6   $��40��6(   
�������{�.  $ Upper=�6q   ��64   Z� ��6�   �� *SecondScore+$ TwoWay=�$ PropertyChanged=�.��6�   5      �� 5"      -   5        $ S3��5"   )   $��1��6   $��0��6   $��10(�65   $��Center=�6C   $��Right=�6e   $ Center=�5#      $��24��6   $��40��6(   $��
24,0,-24,0q�64   
�������{�.  $ Upper=�6�   ��6H   Z� ��6�   �� *
ThirdScore+$ TwoWay=�$ PropertyChanged=�.��6�   5%      �� 5(      $��0��6   $��2,0,0,2q�6   
���   �$��23,0,-24,-1q�6F   $��2��6[   $��2��6o   �� 5*      -   5         ��Name$ Total��5*      $��1��6
   $��2��6&   $��0,0,-24,-32q�6:   $��Center=�6O   ��6m   �� *
TotalScore+$ OneWay=�$ PropertyChanged=��� 5,      $��2��6   $��0,0,-24,-32q�6   $��2��64   $��1q�6E   
���   �6Y   5-      5.      