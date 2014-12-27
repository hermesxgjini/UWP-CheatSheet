//EntraceThemeTransition can be applied to content when the page
//containing the content is first loaded and that part of the content is rendered
//Thus the first appearance of content can offer different visual feedback than a change to content does


<Grid Background="{ThemeResource ApplicationPAgeBackgroundThemeBrush}">
  <Grid.ChildrenTransitions>
    <TransitionCollection>
      <EntraceThemeTransition/>
    <TransitionCollection>
  <Grid.ChildrenTransitions>
</Grid>

<Grid.RowDefinitions>
  <RowDefinition Height="140"/>
  <RowDefinition Height="*"/>
<Grid.RowDefinitions>
....
<Grid/>

 
// Transition animations are used to render a control and are visible in the class diagram show in Figure 6-7.
// If you want to apply one of these transitions,
// you can simply add one them to the TransitionCollection of a control in the following way: 

 <Button>  
   <Button.Transitions>     
     <TransitionCollection>      
       <EntranceThemeTransition FromHorizontalOffset="-229"/> 
     </TransitionCollection> 
   </Button.Transitions> 
 </Button> 