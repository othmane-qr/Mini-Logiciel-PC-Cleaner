   M S B A M L   `   `   `  ���� S  OMini Logiciel PC Cleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Mini_Logiciel_PC_CleanerMini_Logiciel_PC_Cleaner  )    #Mini_Logiciel_PC_Cleaner.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:Mini_Logiciel_PC_Cleaner       � Title$  
MainWindow��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources    FontAwesome��%   &	        *� .��� $��0,0,-0.333,0q� J� RenderTransformOrigin$ 0.572,0.555&� � ColumnDefinitions �� $��0* ��� $��8* ��� $	��53* �.+��� $
��Left=�$��0,0,0,-0.333q�$	��104�����	#FFD5D2D2$	��421��$	��Top=�$��2��.+��� $��80��$��	LOGOC.png��$
��Fill=�
 �� Top$ 10��$	��104���� -    ��Name$ btn_vue��$��VUE D'ENSEMBLE��$	 131��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)�$��1q��� -   $ btn_analysemenu��$��ANALYSER��$	 166��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)��� -   $ btn_histomenu��$��HISTORIQUE
��$	 201��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)��� -   $ btn_options��$��OPTIONS��$	 236��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)��� -   $ btn_site��$��SITE WEB�� �� Left$ 19��$	 323��$��75�����	#FF5BB0F5$��Britannic Bold)��� $ 10��$
��Wrap=�$��VERSION 1.0.0 ��$	 386��$��25��$��84���� -   	 ��Name$
	 txt1��$��2��$	��110��$	��Top=�$	��689�����	#FF5BB0F5$��0,-2,1.667,0q�.+��� -   $ btn_analyse��$��Analyser��$	 501��$ 32��$	��147��$��39��$ 0.5,0.5&�$��24(�$��Britannic Bold)�$
��Bold"��� -   
 ��Name$

 txt2��$ ��Analyse du PC nécessaire ��$ 52��$ 8��$��38��$	��279��$��Britannic Bold)�$��22(�$
��Bold"��� -	   $

 txt3��$3��-Espace a nettoyer : A déterminer par analyse��$ 54��$ 36��$	��320��$��33��$��Britannic Bold)�$��14(��� -
   $

 txt5��$%��Dernière analyse  : 12/01/2020��$ 54��$ 58��$	��320��$��32��$��Britannic Bold)�$��14(��� -   $

 txt4��$)��#Dernière MSJ       : 12/01/2020
 ��$ 54��$ 78��$	��324��$��32��$��Britannic Bold)�$��14(��� -   $ btn_annuler��$��Annuler��$	 501��$ 32��$	��147��$��39��$ 0.5,0.5&�$��24(�$��Britannic Bold)�$
��Bold"�$y�Hidden=�� -    �Name$ bar_pro��$��20��$ 30��$ 44��$	��387��$y�Hidden=� � Value$ 0Q� � Minimum$ 0Q� � Maximum$	 100Q� � IsIndeterminate .  ���	#FF000DFF�� -   $	 Canv_net��$��2��$
��Left=�$	��141��$��
53,167,0,0q�$	��Top=�$	��145�����	#FF5BB0F5.+��� $��36��$ 54��$��sweeping (1).png��$
��Fill=�$ 44��$��43���� -   $ btn_net��$��NETTOYER��$ 95��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)�$ 22���� -   $	 
canv_histo��$��2��$
��Left=�$	��141��$��282,167,0,0q�$	��Top=�$	��145�����	#FF5BB0F5.+��� $��34��$ 54��$��file.png��$
��Fill=�$ 42��$��34���� -   $ 
btn_histor��$��
HISTORIQUE��$ 95��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)�$ 21���� -   $	 canv_metter��$��2��$
��Left=�$	��141��$��511,167,0,0q�$	��Top=�$	��145�����	#FF5BB0F5.+��� $��35��$ 62��$��updated.png��$
��Fill=�$ 40��$��35���� -   $ btn_msj��$��METTER A JOUR��$ 94��$	��104��$��30�����	#FF5BB0F5$
��Bold"�$��Britannic Bold)�$ 23���� $��2��$
��Left=�$��69��$��0,352,0,-0.333q�$	��Top=�$	��689�����	#FFD5D2D2.+��� -    ��Name$
 txt6��$ 29��$
��Wrap=�$ 10��$��49��$	��563��$��Britannic Bold)���Z� �� $P�JQR PC-CLEANER est un logiciel made in Maroc qui respect votre vie privée.���� �� $'�!C' est gratuit et ça le restera.���� -   $
 
txt_anlyse��$�� ��$��2��$
��Left=�$��
53,113,0,0q�$	��Top=�$	��586��$��35��$��Britannic Bold)�$��24(��� -   $

 last��$��2��$
��Left=�$��257,209,0,0q�$	��Top=�