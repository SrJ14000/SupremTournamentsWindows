   M S B A M L   `   `   `  ????S  OSupremTournamentsProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:SupremTournamentsProgram.Vistas.Gestor&SupremTournamentsProgram.Vistas.Gestor  5   	   _4clr-namespace:SupremTournamentsProgram.Convertidores&SupremTournamentsProgram.Convertidores  5   	   F    @SupremTournamentsProgram.Vistas.Gestor.MainEditarTornoIndividual   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:SupremTournamentsProgram.Vistas.Gestor     5   	   Glocal14clr-namespace:SupremTournamentsProgram.Convertidores     5   	     ? 	Resources  5
      =  7SupremTournamentsProgram.Convertidores.BoolToVisibility   boolToVisibility??%   &	          5   
   6"   5      .??5   
   ?   BackgraundColor#??[ 6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   A?  A? Rows$ 1??6   $??0??6   .+?5      ??   MenuButtonStyle#??[ 6V   ??6   ??  ?? Path$- 'AbrirEditarDatosTorneoIndividualCommand?y?6   ?? $ 
IsSelected? ?? 	Converter# [  .??6?   Editar datos Torneo6?   ?? 5      #??[ 6[   ??6   ?? $2 ,AbrirEditarDatosSolicitudesAcceptadasCommand?y?6?   ?? $ 
IsSelected?# [  .??6?   Participantes6?   ?? 5      #??[ 6\   ??6   ?? $3 -AbrirEditarDatosSolicitudesSolicitadasCommand?y?6?   ?? $ 
IsSelected?# [  .??6?   Solicitudes6?   ?? 5      #??[ 6N   ??6   ?? $% AbrirEditarDatosCombatesCommand?y?6w   ?? $ 
IsSelected?# [  .??6?   
Combates6?   5      ?? 5   
   $??1 ??6   ??6'   ?? $ ContenidoVentana? ?? UpdateSourceTrigger$ PropertyChanged=?5      5      