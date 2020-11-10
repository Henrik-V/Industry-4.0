%Paramaters
K = 2.1;
Tc = 15;
Td = 2.9;
%Kp = 1.23; %Skogestad asymtotically stable
%Kp = 3.7585; %Marginally stable
Kp = 8; %Unstable
%Kp = 4.175; %Kc
%Kp = 1.23;
Ti = 11.6;

%Define transfer function
nump = K;
denp = [Tc, 1];
Hp = tf(nump, denp, 'InputDelay', Td);
numc = [Kp*Ti, Kp];
denc = [Ti, 0];
Hc = tf(numc, denc);

L = series(Hc, Hp);

T = feedback(L,1);
S = 1-T;

%Bode plot of f
%bode(L);
%margin(L);

%Step input T
%step(T);

noe = pade(T, 4);
pzmap(noe);