function [out_img , num_lines] = LinesCount(input_img)

%original_img = imread('7.jpg');

%binary_img = im2bw(original_img);
%inv_binary_img = ~binary_img;

%preprocessing...
%SE = strel('disk',2, 4);
eroded_img = input_img;%imerode(inv_binary_img,SE);

%calculate angle of lines...
[h , theta , rho] = hough(eroded_img);
peaks  = houghpeaks(h,10);
lines = houghlines(eroded_img,theta,rho,peaks);

t = lines.theta;
mean_theta = mean(t);

if mean_theta > 90
mean_theta = 180 - mean_theta;
end

horizontal_theta = 90 - mean_theta;

%horizontal structure elemnt..
%strel input (option , length , angle theta ) ..
structure_elemnt = strel('line', size(eroded_img,2),horizontal_theta );
output_img = imdilate(eroded_img, structure_elemnt);


%count number of objects
[~,num_lines] = bwlabel(output_img);

out_img = output_img;
%imshow(output_img);



end

