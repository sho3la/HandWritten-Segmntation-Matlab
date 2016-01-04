function [horz , number_words] = WordCounter(img)

%clear;
%img = imread('5.jpg');

%thresholding..
[thresholded , chars , trigger] = ThreSholding(img);

res = bwmorph(thresholded,'thick',1);



%calculate angle of lines...
[h , theta , rho] = hough(res);
peaks  = houghpeaks(h,10);
lines = houghlines(res,theta,rho,peaks);

t = lines.theta;
mean_theta = mean(t);

if mean_theta > 90
mean_theta = 180 - mean_theta;
end

horizontal_theta = 90 - mean_theta;

if trigger == 1
    
    se = strel('line',20,horizontal_theta);
    horz = imdilate(res,se);
    
    
    tmp = bwconncomp(horz);
    nom = tmp.NumObjects;
    
    if nom <= 10
            se = strel('line',3,horizontal_theta);
            horz = imdilate(res,se);
    end
    
    
else
    se = strel('line',70,horizontal_theta);
    horz = imdilate(res,se);
end



CC = bwconncomp(horz);
number_words = CC.NumObjects;

end

