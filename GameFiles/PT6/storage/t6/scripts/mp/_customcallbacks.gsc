�GSC
     *  �  6  �  �  ,  �  �      @ v          _customcallbacks maps/mp/_utility maps/mp/gametypes/_hud_util common_scripts/utility init setdvarifuninitialized sv_customcallbacks sv_framewaittime sv_additionalwaittime sv_maxstoredframes sv_printradarupdates sv_printradar_updateinterval sv_iw4madmin_url http://127.0.0.1:1624 onplayerconnect runradarupdates prematch_over callbackplayerkilled callback_playerkilled callbackplayerdamage callback_playerdamage callbackplayerdisconnect callback_playerdisconnect dvar val set_dvar_if_unset player connected waitforframethread waitforattack disconnect lastattacktime notifyonplayercommand player_shot +attack interval int i players payload guid ; origin getplayerangles team kills deaths score getcurrentweapon health isalive timeplayed total logprint LiveRadar; 
 hitlocationtobone hitloc helmet j_helmet head j_head neck j_neck torso_upper j_spineupper torso_lower j_spinelower right_arm_upper j_shoulder_ri left_arm_upper j_shoulder_le right_arm_lower j_elbow_ri left_arm_lower j_elbow_le right_hand j_wrist_ri left_hand j_wrist_le right_leg_upper j_hip_ri left_leg_upper j_hip_le right_leg_lower j_knee_ri left_leg_lower j_knee_le right_foot j_ankle_ri left_foot j_ankle_le tag_origin currentangleposition anglepositions waitforadditionalangles logstring beforeframecount afterframecount currentindex anglesnapshot j anglesstr  collectedframes fixedindex : lastattack vector scale process_hit type attacker shitloc smeansofdeath idamage sweapon MOD_FALLING isplayer victim _attacker owner location gettagorigin iskillstreakkill maps/mp/killstreaks/_killstreaks iskillstreakweapon logline Script tag_eye playerads ;0;0 einflictor idflags vpoint vdir psoffsettime boneindex teambased pers Damage maps/mp/gametypes/_globallogic_player deathanimduration Kill disconnected Q   b   ~   &-
 � . �   6-	 ��L=
 � .   �   6-	 ���=
 � .   �   6-
 � .   �   6-
� . �   6- �
 . �   6-
 A
 0. �   6-4    W  6
� iF; 	 -4 g  6
wU%�  !�(  �  !�(  �  !�( - .    6 )
 0U$ %- 4 :  6- 4   M  6?��  &
[W! f(-
 �
 �0  u  6
�U%g!f(?��  ��)�-
h.  �  '('(J; �  �'(_;� 7 �
 �7 �
 �-0    �  
 �7 �
 �7 �
 �7 �
 �7 �
 �-0    �  
 �7 
 �-.    
 �
 7 NNNNNNNNNNNNNNNNNNNN' (-
. 
 9NN. %  6'A? 7� �Q+? '�  M Y   L   
 [
i
u
�
�
�
�
�

)
>
Y
q
�
�
�
�
�Z     T  ����d  ����p  ����|  �����  �����  �����  �����  ����  ����  ����4  ����I  }���b  y���z  u����  q����  m����  i���    e���  �
 [W! �(!�(' ( 
� iH;  -0 �   !�(' A?��-0   �   �!�(
 � j+ �N
� iR!�(?��  ):Jegr��� �'(	  ��L=P+! W('(  �SH;   �! W('A?��
 q'('(	O'(	H; < '(H;  WSfO'(-.    �   W
�NN'('A'A?��F;  W
�NN'('A'(H;@ '(  WSOI;  WSR'(-. �   W
�NN'('A'A?��-g.   �  -  f. �  O'(-.   ' (-

 �
 � 
 �
 9NNNNNNN.    %  6 �� P P P[ �������)n
 �F> -	.    �  9;  '(	'(-	.  �  9= 	7 _; 	7 '(? -	.  �  9= 
 �F; '(--.    ;  0   '('(-	. �  9; '(-.   [  ;  '(
v

 �7 �
 �7 �
 �-
}0     
 �
 �
 �
 �
 �
 �-0  �  
 �-g. �  
 �
 �-0  �  
 �NNNNNNNNNNNNNNNNNNNNNNNNNN' (- 	4   6 ����������� �=  	_= 	G=  	7 �_= 
 � �	7  �F;    IO; -	
�0    �  6- 	
  �  16 	��������-
. �  6-   �  1	6 &X
V- �  1 6 �'�6  �   ����  �  J�;�  W VN7.  M  nr��^  g  ǖ��R	  ; �H�4B
  :  ��
   �=Wi     "�?�6  � ��  �  ��4  �	 ;?q|  �  � >  >  P  d  t  �  �  �  W>   �  g>   �  �>   �  �>   �  �>   �  >  �  :>     M>      u>  E  �>  m  ?  �  �  �  R  �>   �  j
  �
  E  �>   �  >  �  �  %>  6	    �>  [  u  �  �  ;>  �  >  �    [: �  �>   e  >  �  �>    ��  )  �>  V  ��  q  ��  �        �  <  �  N  �
  �  b  �  r  `
  �
  �  �  �   �  j  A �  0 �  w �  ��  ��  ��  �  �  )  d  0   [ 0  H
  f8  V  �  � >  � B  N  �`  �b  D
  �
  �f  ��  ��      � �  �  �  �  �  �  �  �  �  	  �  �  �  �      "  (  .  4  :  @  N  Z  `  ��  ��  �  �  ��  ��  ��  �  �   
	  	  . ,	  9 2	    MT	  [ b	  i f	  u j	  � n	  � r	  � v	  � z	  � ~	   �	  ) �	  > �	  Y �	  q �	  � �	  � �	  � �	  � �	  � �	  T �	  d �	  p �	  | �	  � �	  � �	  � �	  � �	   �	   �	  4 
  I 

  b 
  z 
  � "
  � *
  � 2
  �P
  �
  �
  �
  �
  �V
  t
  �
  �
  �
  �
  )�
  :�
  J�
  e�
  g�
  r�
  ��
  ��
  �
  W�
  �
  0  J  l  �  �  �  q   � N  p  �  �  �  �8  �:  �  8  �<  �  B  �>  �  <  �@  �  :  �B  �  >  �D  F  H  )J  nL  � R  �  �  �  v �  }   � n  ��  6  ��  ��  ��  @  ��  D  ��  ��  � �  ��  �   F   T   �  