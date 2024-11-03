_characters = ["a","b","c","d","e","f","0","1","2","3","4","5","6","7","8","9"]

_addresses = []

import json

for k1 in _characters:
    for k2 in _characters:
        for k3 in _characters:
            for k4 in _characters:
                for k5 in _characters:
                    _addr_generated = f"0x{k1}{k2}{k3}{k4}{k5}"
                    _addresses.append(_addr_generated)

with open("ss","w") as _jf:
    for _addr in _addresses:
        print(_addr)
    _jf.write(str(_addresses))

# _characters = ["a","b","c","d","e","f","0","1","2","3","4","5","6","7","8","9"]

# _addresses = []

# for k1 in _characters:
#     for k2 in _characters:
#         for k3 in _characters:
#             for k4 in _characters:
#                 for k5 in _characters:
#                     for k6 in _characters:
#                         for k7 in _characters:
#                             for k8 in _characters:
#                                 for k9 in _characters:
#                                     for k10 in _characters:
#                                         for k11 in _characters:
#                                             for k12 in _characters:
#                                                 for k13 in _characters:
#                                                     for k14 in _characters:
#                                                         for k15 in _characters:
#                                                             _addr_generated = f"0x{k1}{k2}{k3}{k4}{k5}{k6}{k7}{k8}{k9}{k10}{k11}{k12}{k13}{k14}{k15}"
#                                                             _addresses.append(_addr_generated)

# for _addr in _addresses:
#     print(_addr)

