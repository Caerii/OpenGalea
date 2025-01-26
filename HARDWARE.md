# 3D Files

3d-models/openbci_quest3.blend1 (this is the blender file with the quest 3 scene)

# STL Files for printing

# We are using the large Ultracortex IV modified without the front (6 parietal cortex rings where the HMD/Quest 3 would be)
3d-models/frontbci_withopenface.stl
3d-models/backbci.stl (the regular back half unmodified)

You can use blender to cut out specific configurations for different sizes in order to fit your head. You just need to use boolean subtraction to cut out the parts you want to remove.

Basically just use a sphere mesh, and add a modifier to the ultracortex shell to cut out the sphere (as the selected modifier), use the difference selection and apply in order to cut out the chunks you need in front of the Ultracortex IV.
