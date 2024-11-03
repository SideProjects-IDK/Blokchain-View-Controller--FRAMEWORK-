import hashlib

for xnum in range(0,999):
    for ynum in range(0,999):
        for znum in range(0,999):
            _num = f"{xnum}-{ynum}-{znum}"
            _sha256_hash = hashlib.sha256(f"{_num}".encode())
            print(_sha256_hash)