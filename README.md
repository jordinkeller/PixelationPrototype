# Pixelation Prototype

This program is intended to be a proof of concept. 
The goal is to take an image and process it into a pixelated version of itself that could be used for a cross stitching reference.

The image should have solid continuous colors, clearly defined borders, and be coherent.

**Initial Commit features:**
* Load an image
* Pixelate the image with desired pixel size
* Color reduction

**Things of note:**
* Pixelation is achieved by looking at blocks of pixels determined by pizel size. The average of the colors is then calculated and reapplied to all the pixels within the block.

* PixelSize must be evenly divided by the image dimensions (1920 x 1080 both divide evenly by 2)

* ColorReductionAmount must be between 2 and 256
