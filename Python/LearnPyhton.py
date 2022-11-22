import tkinter as tk

#Process
def show_output():
    number = int(number_input.get())

    if number == 0:
        output_label.configure(text='ไม่แสดงค่า')
        return

    output = ''
    for i in range(1,13):
        output += str(number) + 'x' + str(i)
        output += '=' + str(number*i)+ '\n'

        output_label.configure(text=output)

#UI
window = tk.Tk()
window.title('แม่สูตรคูณ')
window.minsize(width=400,height=400)

title_label = tk.Label(master=window ,text = "แม่สูตรคูณ")
title_label.pack(pady=20)

number_input = tk.Entry(master=window,width=20)
number_input.pack(pady=20)

go_button = tk.Button(
    master=window,text='ตกลง',
    command= show_output,width= 15 ,height=2
    )
go_button.pack()

output_label = tk.Label(master=window)
output_label.pack(pady=20)

window.mainloop()


