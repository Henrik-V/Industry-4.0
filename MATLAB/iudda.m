%num = 1;
%den = [1, 2, 1, 0];

%num = 1;
%den = [1, 1];

num = 1;
den = [1, 1, 0];

H = tf(num, den)

bode(H)