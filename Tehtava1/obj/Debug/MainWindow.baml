   M S B A M L   `   `   `  ����  Tehtava1    Tehtava1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Keski-Suomen Ikkunat Oy��5   	   $	��350��6)   $��544.466��66   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5	   
   �� -   5         ��Name$
 txtL��5	      $
��Left=�6    $��23��6;   $��
359,24,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $
��1200��6o   $	��Top=�6{   $	��120��6�   �� 5
   
   -   5        $
 txtH��5
      $
��Left=�6    $��23��6;   $��
359,52,0,0q�6G   $
 Wrap=�6[   $	��900��6o   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $
 txtW��5      $
��Left=�6    $��23��6;   $��
359,80,0,0q�6G   $
 Wrap=�6[   $��45��6o   $	��Top=�6y   $	��120��6�   �� 5   
   $��Ikkunan leveys (L):��6   $
��Left=�6.   $��
247,21,0,0q�6I   $	��Top=�6]   �� 5   
   $��Ikkunan korkeus (H):��6   $
��Left=�6/   $��
234,52,0,0q�6J   $	��Top=�6^   �� 5   
   $��Karmin leveys (W):��6   $
��Left=�6-   $��
245,83,0,0q�6H   $	��Top=�6\   �� 5   
   -   5         ��Name$ btnCalculation��5      $��Laske pinta-ala ja piiri��6)   $
��Left=�6L   $��344,121,0,0q�6g   $	��Top=�6|   $	��135��6�   6�   �� 5   
   $��Ikkunan pinta-ala:��6   $
��Left=�6-   $��249,161,0,0q�6H   $	��Top=�6]   �� 5   
   $��Karmin pinta-ala:��6   $
��Left=�6,   $��252,192,0,0q�6G   $	��Top=�6\   �� 5   
   $��Karmin piiri:��6   $
��Left=�6(   $��279,223,0,0q�6C   $	��Top=�6X   �� 5   
   -   5        $ rsltWindowArea��5      $
��Left=�6*   $��359,162,0,0q�6E   $
 Wrap=�6Z   $��tulos 1��6n   $	��Top=�6}    J� RenderTransformOrigin$ 0.978,-0.082&�6�   $	��120��6�   �� 5   
   -   5        $ rsltFrameArea��5      $
��Left=�6)   $��360,193,0,0q�6D   $
 Wrap=�6Y   $��tulos 2��6m   $	��Top=�6|   $ -0.138,-0.383&�6�   $	��119��6�   �� 5   
   -   5        $ rsltFramePerimeter��5      $
��Left=�6.   $��361,223,0,0q�6I   $
 Wrap=�6^   $��tulos 3��6r   $	��Top=�6�   $	��118��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��130��6@   $��	28,75,0,0q�6M   
���   �$	��Top=�6o   $	��184��6�   5      5      