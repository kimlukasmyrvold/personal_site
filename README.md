# Personal Site

> Personal Website made with Blazor WebAssembly using .net 8.0

This is my personal website where you can learn more about me, you can find personal info, coding languages I know, were I went to school and more.


<br>

# Changelog

All notable changes to this project will be documented in this file.

The format for this file is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).<br>
Dates use the [ISO 8601 date format](https://www.iso.org/iso-8601-date-and-time-format.html) of `YYYY-MM-DD`.

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


[0.2.0]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.2.0
[0.1.0]: https://github.com/kimlukasmyrvold/kimlukasmyrvold.github.io/releases/tag/v0.1.0