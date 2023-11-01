import tkinter as tk
from tkinter import Entry
from ttkbootstrap.constants import *
import ttkbootstrap as ttk



window = tk.Tk() #instantiate an instance of a window
window.geometry("420x420")
window.title("Spanish Conjactor")

#make varibles
def All_cal():
   Noun_Entry_text = Noun_Entry.get()
   Verb_Entry_text = Verb_Entry.get()
   print(Noun_Entry_text)
   print(Verb_Entry_text)
   sup = 0
   res = '.'
   c = input()
   b = str(input())
   a = [b]
   d = b.split()
   cat = len(d)
   dog = cat - 2
   rabbit = d[dog] 
   if c == 'Yo':
      for i in d:
        sup += 1
        res += i
        if sup == dog:
          res = res + 'o'
          print(res)
          break
   elif c == 'Tu' and rabbit == 'e':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'es'
                print(res)
                break
   elif c == 'Tu' and rabbit == 'a':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'as'
                print(res)
                break
   elif c == 'Tu' and rabbit == 'i':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'es'
                print(res)
                break
   elif c == 'Ella' or c == 'El' or c == 'Ud.'and rabbit == 'a':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'a'
                print(res)
                break  
   elif c == 'Ella' or c == 'El' or c == 'Ud.'and rabbit == 'i':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'e'
                print(res)
                break
   elif c == 'Ella' or c == 'El' or c == 'Ud.'and rabbit == 'e':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'e'
                print(res)
                break
   elif c == 'Nosotros' and rabbit == 'e':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'emos'
                print(res)
                break
   elif c == 'Nosotros' and rabbit == 'a':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'amos'
                print(res)
                break
   elif c == 'Nosotros' and rabbit == 'i':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'imos'
                print(res)
                break
   elif c == 'Ellas' or c == 'Ellos' or c == 'Uds.'and rabbit == 'e':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'en'
                print(res)
                break
   elif c == 'Ellas' or c == 'Ellos' or c == 'Uds.'and rabbit == 'i':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'en'
                print(res)
                break
   elif c == 'Ellas' or c == 'Ellos' or c == 'Uds.'and rabbit == 'a':
        for i in d:
            sup += 1
            res += i
            if sup == dog:
                res = res + 'an'
                print(res)
                break

#Define an Entry widget
Noun_Entry = Entry(window, width= 40)
Noun_Entry.pack(pady=10)

Verb_Entry = Entry(window, width= 40)
Verb_Entry.place(relx=0.5, rely=0.5, anchor='center')

#Create Buttons with proper position
Noun_but = ttk.Button(window, text= "All Enter", command = All_cal)
Noun_but.pack()

window.mainloop()





 


 



