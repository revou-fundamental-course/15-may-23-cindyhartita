#Program kalkulator sederhana menggunakan 4 pilihan operasi (tambah, bagi, kali, pengurangan)

print("==================")
print("Numerare Numerus")
print("==================")

print("powered by:")
print("Cindy \n")

print ("===============")
print("Pilihan Operasi")
print("1. Tambah")
print("2. Kurang")
print("3. Bagi")
print("4. Kali")
print ("===============")

operasi = int(input("masukkan pilihan operasi(1/2/3/4 : "))

if operasi == 1:
    x = int (input("Masukkan nilai pertama : "))
    y = int (input("Masukkan nilai kedua : "))
    z = x + y
    print("Hasilnya adalah : ", x, "+", y, "=", z)
    print("=========================")

elif operasi == 2:
    x = int (input("Masukkan nilai pertama : "))
    y = int (input("Masukkan nilai kedua : "))
    z = x - y
    print("Hasilnya adalah : ", x, "-", y, "=", z)
    print("=========================")


elif operasi == 3:
    x = float (input("Masukkan nilai pertama : "))
    y = float (input("Masukkan nilai kedua : "))
    z = x / y
    print("Hasilnya adalah : ", x, "/", y, "=", z)
    print("=========================") 

elif operasi == 3:
    x = int (input("Masukkan nilai pertama : "))
    y = int (input("Masukkan nilai kedua : "))
    z = x * y
    print("Hasilnya adalah : ", x, "x ", y, "=", z)
    print("=========================")