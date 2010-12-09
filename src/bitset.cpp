/**
 * @file bitset.cpp
 */
#include <stdafx.h>
#include <spaghetti/bitset.hpp>


bool bitset_is_include(bitset_t self, bitset_t other_bitset)
{
    return (self & other_bitset) == other_bitset;
}


bitset_t bitset_inversion(bitset_t self)
{
    return self ^ ~0;
}


bitset_t bitset_difference(bitset_t self, bitset_t other)
{
    return self ^ (self & other);
}
