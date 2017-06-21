# Demo #
### Description ###
A C# merge-sort implementation. The merge-sort application generates or accepts as input a list/array of random numbers, and uses the merge sort algorithm to perform an ascending sort of the list/array elements. The method uses multi-threading to speed up sorting.

### Usage e.g.: ###
	demo [-accept integers | -generate quantity biggest]

	integer:\t a series of integers to be sorted, seperated by a single space.
	quantity:\t an integer indicating the number of random integers to generate.
	biggest:\t an integer indicating the largest random integer to generate.

	For example:
		demo -accept 12 4 7 99 13
		or:
		demo -generate 10 500