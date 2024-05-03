# CSCI 535 Project - Jacob Hofer
## Repository Overview
This repository contains my final project for CSCI 535. The main topic at hand is a study of how to apply topological concepts to physics simulations. 

The repository consists of the following:
- Slideshow and notes detailing the various topological concepts and algorithms used to simulate physics in the presence of topological changes.
- Unity project for creating 3D meshes from CT scan data implementing the marching cubes algorithm.
- Jupyter notebook detailing a tutorial on using the Unity project to load the provided (or your own!) data.

## Repository Structure and Files
This repository consists of various files. They are detailed here:
- [Topological Concepts in Physics Simulations.pdf](https://github.com/CodeAX2/CTData/blob/main/Topological%20Concepts%20in%20Physics%20Simulations.pdf)
  - Slideshow presentation detailing the various topics studied.
- [Darts and i-cells.pdf](https://github.com/CodeAX2/CTData/blob/main/Darts%20and%20i-cells.pdf)
  - Written notes containing definitions and examples over darts and $i$-cells.
- [CTAData.ipynb](https://github.com/CodeAX2/CTData/blob/main/CTData.ipynb), [NotebookImages/](https://github.com/CodeAX2/CTData/tree/main/NotebookImages)
  - Jupyter notebook tutorial for creating meshes from CT scan data.
- [readdata.py](https://github.com/CodeAX2/CTData/blob/main/readdata.py)
  - Python script to convert `.nrrd` files to `.txt` files used in the Unity project.
- [CTA-cardio.nrrd](https://github.com/CodeAX2/CTData/blob/main/CTA-cardio.nrrd)
  - `.nrrd` file containing CT scan data of a patient's torso.
- [.vscode/](https://github.com/CodeAX2/CTData/tree/main/.vscode), [Assets/](https://github.com/CodeAX2/CTData/tree/main/Assets), [Packages/](https://github.com/CodeAX2/CTData/tree/main/Packages), [ProjectSettings/](https://github.com/CodeAX2/CTData/tree/main/ProjectSettings), [.clang-format](https://github.com/CodeAX2/CTData/blob/main/.clang-format)
  - Unity project files.

It is important to note that `data.txt`, which the project uses to load the function data, is not included as it is too large a file. This file can be obtained by using the `readdata.py` script to convert from the `.nrrd` file.
