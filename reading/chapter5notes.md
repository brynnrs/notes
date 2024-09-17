## Canvas Concepts

> What are the elements used in a table? How should they be organized?
- `<table>`, `<tr>` (for rows), `<th>` (for headers), and `<td>` (for data cells). There's also `<caption>` to add a brief title or description of the table and `<thead>`, `<tfoot>`, and `<tbody>` for tables with lots of rows. Less commonly used are `<col>` and `<colgroup>` for eventually styling the table by groups of columns.


The way to organize these elements is as follows:
~~~    
<table>
    <caption>Brief Description of the Table</caption>
    <colgroup id="columnGroupName">
        <col />
        <col span="2" class="className">
        <col span="2" class="2ndclassName">
    </colgroup>

    <thead>
      <tr>
        <th>Heading 1</th>
        <th>Heading 2</th>
        <th colspan="2">Heading 3 Spans 2 Columns</th>
      </tr>
    </thead>
    <tfoot>
      <tr>
        <td>Footer Column 1</td>
        <td>Footer Column 2</td>
        ...
      </tr>
    </tfoot>
    <tbody>
      <tr>
        <td rowspan="3">Data Cell 1 Spans 2 Rows</td>
        <td>Data Cell 2</td>
        <td>Data Cell 3</td>
        <td>Data Cell 4</td>
      </tr>
    </tbody>
</table>
~~~

> What does it mean to use tables for layout? Why should it be avoided?
- Before browsers widely supported CSS, HTML tables were used to create page layouts. They were used as a work-around way to style block-level elements next to each other on the same line. 
- This should be avoided because it tends to increase the size of HTML documents, the markup is not semantic, and it results in a page that is not accessible to those using software to voice the content.

> What did you learn as you styled your first table?
- I learned that the `<tfoot>` element comes before the `<tbody>` element. I also learned that you can change the location of the table caption by using the CSS property `caption-side`. I also learned that tables have borders with different models you can style using `border-collapse`. 

> What CSS properties are important when styling tables?
- `border-collapse` is used to choose either `separated` or `collapsed` border model and `border-spacing` is useful for styling the space between adjacent borders in the default `separated` model.

> What elements are part of a form? Describe the purpose of each element.
- A form is defined by a `<form>` element and can contain almost any other HTML element *except* another `<form>`. 
- `<>` (), `<>` (), and `<>` (). There's also `<>` to ... and `<>`, `<>`, and `<>` for ... Less commonly used are `<>` and `<>` for ...

> Figure 5.12 describes how forms allow the browser to send data to a server. Describe this process in your own words.
- First an HTTP request is made with form elements in the requested HTML

> How does form data get formatted as a query string?
- 

> Figure 5.15 shows an HTTP GET request and an HTTP POST request, what is the difference between the two?
- 

> Make a list of all the different ways a user can input data on a form.
- 

> What does it mean for a form to be accessible?
- 

> What is the relationship between the `for` and `id` attributes?
- 

> What CSS attributes are usefull when styling forms?
- 

> What kinds of things can you validate on a form?
- 

> How can you use the range and required attributes?
- 


## Questions:

- What is the `<col>` element used for? Why is it sometimes inside the `<colgroup>` element and sometimes outside of it?
- 