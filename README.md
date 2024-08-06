# Personal Site

> Personal Website made with Blazor WebAssembly using .net 8.0

This is my personal website where you can learn more about me, you can find personal info, coding languages I know, were I went to school and more.


<br>

# Changelog

All notable changes to this project will be documented in this file.

The format for this file is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).<br>
Dates use the [ISO 8601 date format](https://www.iso.org/iso-8601-date-and-time-format.html) of `YYYY-MM-DD`.


## [0.3.2] - 2024-08-06

### Changed

- Removed underline from show more button in `_timeline.scss`
- Added more spacing to elements in `_timeline.scss`


## [0.3.1] - 2024-07-31

### Added

- added JavaScript file for footer map in `ol.js` and `ol.js.map`

### Changed

- changed styling for link elements, also moved from `_base.scss` to `_typography.scss` in `_typography.scss`
- changed text for GitHub link from `Check out the code here` to `Website is open source:` in `Footer.razor`
- improved metadata for head in `index.html` and `404.html`

### Removed

- removed note telling user that all dates on website follows iso-8601 date format in `Footer.razor`
- removed Google Analytics scripts from head in `index.html`


## [0.3.0] - 2024-06-20

### Added

- New images in `/Places`
- new class for viewing large images in `_image.scss`
- margin 0 to certain text elements in `_typography.scss`
- component for viewing image in large view `ImageViewer.razor`
- noscript tag to tell user that javascript must be enabled to work `index.html`
- json file for storing job timeline data in `JobTimeline.json`
- json file for storing school timeline data in `SchoolTimeline.json`
- main javascript file for functions `Main.js`
- new components for timeline `Timeline.Event.Description.razor`, `Timeline.Event.razor`, `Timeline.Marker.razor` and `Timeline.razor`
- model for json timeline `TimelineModel.cs`

### Changed

- styling for visually_hidden class in `_base.scss`
- styling for buttons in `_button.scss`
- Version in `Footer.razor`
- spacing of <main> element and hide horizontal overflow in `_main.scss`
- entire styling for timeline component in `_timeline.scss`
- Work- and school timeline to use new timeline component in `Home.razor`

### Removed

- Unused model `CodeLanguagesModel.cs`
- old components for work- and school timeline `SchoolTimeline.razor` and `WorkExperienceTimeline.razor` 


## [0.2.2] - 2024-06-11

### Added

- gap to #hero section, fixes "scroll to see more" text clipping into .bio on smaller screens. `_home.scss`

### Changed

- updated version in `Footer.razor` 


## [0.2.1] - 2024-06-11

### Added

- Onclick listener for scrolling to "scroll to see more" text in `Home.razor`

### Changed

- output location of publish in `package.json`
- color of `--text5` to be slightly lighter 5% to 7% in `_dark.scss`
- Version in `Footer.razor`


## [0.2.0] - 2024-06-11

### Added

- README file that also includes the changelog for this project `README.md`
- Styling for code element and added blur to information_popup class in `_base.scss`
- box-shadow hover effect to image and transition for opacity for radial-gradient on wrapper in `_bio.scss`
- box-shadow and blur to card in `_codingLanguages.scss`.
- Styling for experimental masonry grid template rows layout. (will look cool on browsers that support it) in `_codingLanguages.scss`
- Styling for scroll class in `_home.scss`
- Styling for timeline component in `_timeline.scss`
- More template columns to wrapper, inline and small in `_wrapper.scss`
- New png image for bli synlig in `Images/Places/`
- Information section to tip to user what browser support new masonry layout in `CodingLanguages.razor`
- Div to hero for hinting scroll, school timline and work experience timeline in `Home.razor`
- Component for viewing timelines in `Timeline.razor`
- Component for viewing timeline of schools I have gone to in `SchoolTimeline.razor`
- Component for viewing timeline of work places I have worked at in `WorkExperienceTimeline.razor`

### Changed

- Made brand link not tabable in `Header.razor`
- Version in `Footer.razor`
- Color of radial-gradient and background-color of container in `_codingLanguages.scss`
- Display grid to flexbox and increased min-height from 80dvh to 90dvh in `_home.scss`
- Position of mouseposstyling in `Bio.razor`
- method for hiding and showing projects/certificates more strict in `CodingLanguages.Card.razor`
- 

### Removed

- Styling for transforming image in `_bio.scss`
- Detection and method for mouseleave, and javascript call to transform image on mouse hover in `Bio.razor`
- Mouseposstyling, callback for when show more/less button clicked in `CodingLanguages.Card.razor`
- Unused variables in `CodingLanguages.razor`
- Unused functions in `index.html`


## [0.1.0] - 2024-05-02

### Added

- The initial Blazor website, includes
  - Header, Footer, Main section
  - Bio (personal info about me)
  - Notice for website under construction
  - Coding languages I have worked with
- GPL3.0 license

### Note

- Footer shows wrong version 2.0.0


## Previous website

Link to site https://old.kimlukas.com/.
You can find the code for it at: https://github.com/kimlukasmyrvold/old_personal_site/.
No changelog for the old website was properly tracked.


[0.3.2]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.3.2
[0.3.1]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.3.1
[0.3.0]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.3.0
[0.2.2]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.2.2
[0.2.1]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.2.1
[0.2.0]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.2.0
[0.1.0]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.1.0