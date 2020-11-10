%Paramaters
K = 2.1;
Tc = 15;
Td = 2.9;

%Define transfer function
num = K;
den = [Tc, 1];
H = tf(num, den, 'InputDelay', Td);

%Frequency response
bode(H);
grid on;

w = [0.001 0.01 0.1 1 3 5 10];

[magw, phasew] = bode(H, w);

for i=1:length(w)
    mag(i) = magw(1,1,i);
    phase(i) = phasew(1,1,i);
end

magdB = 20*log10(mag);%Convert to dB
mag_data = [w; magdB];
phase_data = [w; phase];