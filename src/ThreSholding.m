function [ binaryimg ,charactersNo , trigger ] = ThreSholding( img )
%THRESHOLDING Summary of this function goes here
%   Detailed explanation goes here

trigger = 0;

hsv_image = rgb2hsv(img);

mat = hsv_image(:,:,2);
mat = mat2gray(mat);

bw = im2bw(mat,0.28);

bw = bwareaopen(bw,100);

bw = bwmorph(bw,'thicken',2);

CC = bwconncomp(bw);
charactersNo  = CC.NumObjects;

if charactersNo == 0
    
    trigger = 1;
    mat = hsv_image(:,:,3);
    mat = mat2gray(mat);
    bw = im2bw(mat,0.6);
    
    bw = bwareaopen(bw,50);
    bw = ~bw;
    
    CC = bwconncomp(bw);
    charactersNo  = CC.NumObjects;
    
end

imshow(bw);
binaryimg = bw;

end

