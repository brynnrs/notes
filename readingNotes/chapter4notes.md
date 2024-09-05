## Key Terms

- absolute units  
- attribute selector  
- author-created style sheets  
- block-level elements  
- box model  
- browser style sheets  
- cascade  
- Cascading Style Sheets  
- class selector  
- collapsing margins  
- combinators  
- contextual selector  
- CSS  -  **C**ascading **S**tyle **S**heets  
    - W3C standard for describing the appearance of HTML elements  
    - defines the presentation of HTML documents
- CSS framework  
- CSS variable  
- CSS3 modules  
    - CSS Selectors
    - CSS Namespaces
    - CSS Media Queries
    - CSS Color
    - CSS Fonts
    - CSS Basic UI
    - CSS Grids
    - CSS Style Attributes
- declaration  
- declaration block  
- descendant selector  
- Document Object Model  
- element box  
- element selectors  
- em units  
- embedded style sheets  
- external style sheets  
- generic font  
- grouped selector  
- id selector  
- inheritance  
- inline styles  
- location  
- margin  
- padding  
- percentages  
- property  
- property:value pair  
- pseudo-class selector  
- pseudo-element selector  
- relative units  
- rem  
- responsive design  
- selector  
- specificity  
- style rules  
- universal element   
- selector  
- user style sheets  
- vendor prefixes  
- web font stack  
- x-height  


## Review Questions

1. What are the main benefits of using CSS?
    - Improved control over formatting
    - Improved site maintainability
    - Improved accessibility
    - Improved page-download speed
    - Improved output flexibility

2. Compare the approach the W3C has used with CSS3 in comparison to 
CSS2.1.

3. What are the different parts of a CSS style rule?
    - a selector that identifies HTML element(s) that will be affected
    - declaration  -  a `property:value` pair
    - declaration block  -  a series of `property:value` pairs
4. What is the difference between a relative and an absolute measure unit in CSS? Why are relative units preferred over absolute units in CSS?
5. What is an element selector and a grouped element selector? Provide an 
example of each.
6. What are class selectors? What are id selectors? Briefly discuss why you would use one over the other.
7. What are contextual selectors? Identify the four different contextual selectors.
8. What are pseudo-class selectors? What are they commonly used for?

## Canvas Concepts

### Vocab: 

>What is a property?  
- a characteristic of an element that can be styled, like `color`, `font-size`, etc.
>What is a declaration block?  
- a series of `property:value` pairs enclosed in curly braces`{}`that define the styles for the selected element(s)
>What is a selector?  
- The first part of a CSS rule used to identify which HTML element(s) will be styled by the declaration(s) in the rule.


### Properties:

*(Make a list of all properties mentioned in the chapter with a quick description of their purpose.)*

#### Background *(p.153)*
> | Property | Description |
> |----------|-------------|
> | background | combined shorthand property that allows multiple background values to be set in one property; any ommitted properties with shorthand will be set to default value. |
> | background-attachment | specifies whether image scrolls with document or remains fixed. Possible Values: `fixed`,`scroll`,`local`. |
> | background-color | sets background color of element. |
> | background-image | specifies background image (generally `jpeg`, `gif`, or `png`) for the element with URL relative to CSS file, not the HTML. (Gradient color fills can be specified with this property.) |
> | background-origin | sets beginning location of image within parent. |
> | background-position | specifies where on the element the background image will be placed. Possible Values: `bottom`,`center`,`left`, and `right`.  |
> | background-repeat | determines whether background image will be repeated (i.e., default behavior, common technique for tiled background). Possible Values: `repeat`,`repeat-x`,`repeat-y`, and `no-repeat`.|
> | background-size | sets size of image and how image should fill space within parent. |

#### Border *(p.156)*
> | Property | Description |
> |----------|-------------|
> | border | combined shorthand property that allows the style, width, and color of a border to be set in one property. The order is important and must be: `border-width` `border-style` `border-color` |
> | border-style | specifies line type of the border. Possible values: `solid`, `dotted`, `dashed`, `double`, `groove`, `ridge`, `inset`, `outset`, `hidden`, and `none` |
> | border-width | width of the border in a unit (but not percents). A variety of keywords (`thin`, `medium`, etc.) are also supported. |
> | border-color | color of the border in a color unit. |
> | border-radius | radius of a rounded corner. |
> | border-image | the URL of an image to use as a border. |
> | box-shadow | adds shadow effect to an element. Values: `offset-x`, `offset-y`, `blur-radius`, `spread-radius`, `color`. |

#### Font *(p.166)*
> | Property | Description |
> |----------|-------------|
> | font | combined shorthand property that allows the family, style, size, variant, and weight to be set in one property. Must include font size and font family. Order is important and must be: `style`, `weight`, `variant`, `size`, `font-family` |
> | font-family | specifies the typeface/font (or generic font family to use.) More than one can be specified. |
> | font-size | size of font in one of the measurement units. |
> | font-style | specifies whether `italic`, `oblique` (i.e., skewed by browser rather than true italic), or `normal`. |
> | font-variant | specifies either `small-caps` text or `none`(i.e., regular text). |
> | font-weight | specifies either `normal`, `bold`, `bolder`, `lighter`, or a value between `100` and `900` in multiples of 100, the larger the number the larger weight (bold) of the text. |


#### Text *(172-173)*
> | Property | Description |
> |----------|-------------|
> | letter-spacing | adjusts the space between letters. Can be the value `normal` or a length unit. |
> | line-height | specifies space between baselines (equivalent to leading in a desktop publishing program). Default value is `normal`, but can be set to any length unit. Can also be set via the shorthand font property. |
> | list-style-image | specifies the URL of an image to use as the marker for unordered lists. |
> | list-style-type | selects marker type for ordered and unordered lists. Commonly set to `none` for navigational menus or input forms. |
> | text-align | aligns text horizontally in container element (similar to word processors). Possible values: `left`, `right`, `center`, and `justify`.|
> | text-decoration | specifies whether text will have lines below, through, or over it. Possible values: `none`, `underline`, `overline`, `line-through`, and `blink`. Hyperlinks have `underline` set by default. |
> | text-direction | specifies direction of text, left-to-right (`ltr`) or right-to-left (`rtl`).|
> | text-indent | indents first line of paragraph by a specific amount. |
> | text-shadow | new CSS3 property, can be used to add drop shadow to text. |
> | text-transform | changes the capitalization of text. Possible values: `none`, `capitalize`, `lowercase`, and `uppercase`. |
> | vertical-align | aligns inline, inline-block, or table text or images vertically in container element. Most common values:`top`, `bottom`, and `middle`. Can't be used to vertically align block-level elements. |
> | word-spacing | adjusts space between words. Can be value `normal` or a length unit. |


What counts as a valid color value in CSS?  
- HEX values (`#FF0000`), RGB values (`rgb(255,0,0)`), RGBA values (`rgba(255,0,0,0.5)`), HSL values (`hsl(0,100%,50%)`), and HSLA values(`hsla(0,100%,50%,0.5)`)  

What are the relative and absolute units in CSS? What makes a relative unit different from an absolute unit?  
- Relative units are things like `em`,`rem`,`%`, and `vh/vw`. They scale based on other values like font or viewport size.
- Absolute units include `px`,`pt`,`cm`,`mm`, and `in`. They're fixed and don't scale.  

What are the three places you can put CSS?  
- Inline (*using the `style` attribute in HTML*)
- Internal (*with the `style` tag in HTML*)
- External (*by linking a `.css` file*)  

### Selectors:

*(Make a list of all the different ways you can select an HTML element using "selectors".)*  
>
>- Type (`element`)
>- Class (`.class`)
>- ID (`#id`)
>- Attribute (`[attribute=value]`)
>- Pseudo-class (`:hover`)
>- Pseudo-element (`::before`)
>

What do pseudo elements select?  
- more specific parts of elements, such as `:first-line` or `:first-letter`  

What are the purposes of pseudo classes?  
- to target elements in a specific state, like `:hover` or `:first-child`

What are some properties that are inherited from parent to child? What are some properties that are not inherited?  
- **Inherited Properties** are things like `color`, `font-family`, `font-size`, and `line-height`.
- **Non-Inherited Properties** would be things like `margin`, `padding`, `border`, and `background`.

When rules conflict, how does the browser decide which rule to render?  
- It uses specificity and the `!important` flag to decide which rule takes precedence and resolve conflicts.

What is the difference of block vs inline?  
- **Block**-level elements take the full width of their parent and start on a new line, like `div`.
- **Inline** elements only take as much width as is needed, will adjust the content to fit the width if it changes, and are displayed within lines, like `span`.

How do you change the font? What other things can you do to modify text?  
- You can change the font by using the `font-family` property, or modify the text with properties like `text-align`, `line-height`, `letter-spacing`, etc. 

How do you declare and use CSS variables?  
- CSS Variables must begin with a double hyphen and can be defined at the top of a CSS file, usually within `:root` pseudo-class selector. They can then be used by referencing them using the `var()` CSS function.