(function($){
    "use strict"; // Start of use strict
jQuery(document).ready(function($){  
		
		$("#gototop").hide();
		$(function () {
			var wh = $(window).height();
			var whtml =  $(document).height();			
			$(window).scroll(function () {				
				if ($(this).scrollTop() > whtml/10) {
					$('#gototop').fadeIn();
				} else {
					$('#gototop').fadeOut();
				}
			});
			$('#gototop').click(function () {
				$('body,html').animate({
					scrollTop: 0
				}, 800);
				return false;
			});
		});
		
				$('.vt-slider67 div.products-grid').owlCarousel({
					items: 4,
					itemsCustom: [ 
						[0, 1], 
						[480, 2], 
						[768, 2], 
						[992,3], 
						[1200,3] 
					],
					pagination: true,
					slideSpeed : 800,
					addClassActive: true,
				});

	$(window).scroll(function () {		
		if($(window).width()>768)
		{
			if ($(this).scrollTop() >0) {
				$('.box-header-01').addClass('fixed');
			} else {
				$('.box-header-01').removeClass('fixed');
			}
		}
	});
	$('.menu .megamenu-parent').hover(function(){
	$('.bgr-menu').css('display','block');
		},function(){
			$('.bgr-menu').css('display','none');
	}); 
	
	
	jQuery('.drop-search span.selected').click(function(){
	jQuery('.drop-search ul').toggleClass('show');
	});
	jQuery('.drop-search ul li').click(function(){
	jQuery('.drop-search .selected').html(jQuery(this).html());
	jQuery('.drop-search ul').toggleClass('show');
	});
	jQuery("body").click(function() {
	jQuery('.drop-search ul').removeClass('show');
	});
	jQuery(".drop-search").click(function(e) {
		e.stopPropagation();
	});
	
	
	$('.vt-slideshow').revolution({
	 startwidth:1170,
	 startheight:400,			 
  });
	
	
	if(jQuery( window ).width()<769){
		var ct1=jQuery( window ).width(),ct2=ct1*2,ct3=ct1*3,ct4=ct1*4;
		jQuery('.box-1 .control li.ct2').attr('data-rel','-'+ct1+'px');
		jQuery('.box-1 .control li.ct3').attr('data-rel','-'+ct2+'px');
		jQuery('.box-1 .control li.ct4').attr('data-rel','-'+ct3+'px');
		jQuery('.box-1 .control li.ct5').attr('data-rel','-'+ct4+'px');
		jQuery('.box-2 .slide .item').css('width',ct1+'px');
	}
	jQuery('.box-1 .control li').click(function(){
	jQuery('.box-2 .slide').animate({left: jQuery(this).attr('data-rel')});
	jQuery('.box-1 .control li').removeClass('active');
	jQuery(this).addClass('active');
	});
	

	$('.vt-slider3 div.products-grid').owlCarousel({
		items: 4,
		itemsCustom: [ 
			[0, 1], 
			[480, 2], 
			[768, 3], 
			[992,4], 
			[1200,4] 
		],
		pagination: false,
		slideSpeed : 800,
		addClassActive: true,
		afterAction: function (e) {
			if(this.$owlItems.length > this.options.items){
				$('.vt-slider3 .navslider').show();
			}else{
				$('.vt-slider3 .navslider').hide();
			}
		}
		//scrollPerPage: true,
	});
	$('.vt-slider3 .navslider .prev').on('click', function(e){
		e.preventDefault();
		$('.vt-slider3 div.products-grid').trigger('owl.prev');
	});
	$('.vt-slider3 .navslider .next').on('click', function(e){
		e.preventDefault();
		$('.vt-slider3 div.products-grid').trigger('owl.next');
	});
	
	$('.vt-slider4 div.products-grid').owlCarousel({
		items: 1,
		itemsCustom: [ 
			[0, 1], 
			[480, 1], 
			[768, 1], 
			[992,1], 
			[1200,1] 
		],
		pagination: false,
		slideSpeed : 800,
		addClassActive: true,
		afterAction: function (e) {
			if(this.$owlItems.length > this.options.items){
				$('.vt-slider4 .navslider').show();
			}else{
				$('.vt-slider4 .navslider').hide();
			}
		}
		//scrollPerPage: true,
	});
	$('.vt-slider4 .navslider .prev').on('click', function(e){
		e.preventDefault();
		$('.vt-slider4 div.products-grid').trigger('owl.prev');
	});
	$('.vt-slider4 .navslider .next').on('click', function(e){
		e.preventDefault();
		$('.vt-slider4 div.products-grid').trigger('owl.next');
	});
	

		$('.vt-slider7 div.products-grid').owlCarousel({
			items: 4,
			itemsCustom: [ 
				[0, 1], 
				[480, 2], 
				[768, 3], 
				[992,4], 
				[1200,4] 
			],
			pagination: false,
			slideSpeed : 800,
			addClassActive: true,
			afterAction: function (e) {
				if(this.$owlItems.length > this.options.items){
					$('.vt-slider7 .navslider').show();
				}else{
					$('.vt-slider7 .navslider').hide();
				}
			}
			//scrollPerPage: true,
		});
		$('.vt-slider7 .navslider .prev').on('click', function(e){
			e.preventDefault();
			$('.vt-slider7 div.products-grid').trigger('owl.prev');
		});
		$('.vt-slider7 .navslider .next').on('click', function(e){
			e.preventDefault();
			$('.vt-slider7 div.products-grid').trigger('owl.next');
		});
		
		$('.vt-slider5 div.products-grid').owlCarousel({
			items: 4,
			itemsCustom: [ 
				[0, 1], 
				[480, 2], 
				[768, 3], 
				[992,4], 
				[1200,4] 
			],
			pagination: false,
			slideSpeed : 800,
			addClassActive: true,
			afterAction: function (e) {
				if(this.$owlItems.length > this.options.items){
					$('.vt-slider5 .navslider').show();
				}else{
					$('.vt-slider5 .navslider').hide();
				}
			}
			//scrollPerPage: true,
		});
		$('.vt-slider5 .navslider .prev').on('click', function(e){
			e.preventDefault();
			$('.vt-slider5 div.products-grid').trigger('owl.prev');
		});
		$('.vt-slider5 .navslider .next').on('click', function(e){
			e.preventDefault();
			$('.vt-slider5 div.products-grid').trigger('owl.next');
		});
		
		$('.vt-slider6 div.products-grid').owlCarousel({
		items: 4,
		itemsCustom: [ 
			[0, 1], 
			[480, 2], 
			[768, 3], 
			[992,4], 
			[1200,4] 
		],
		pagination: false,
		slideSpeed : 800,
		addClassActive: true,
		afterAction: function (e) {
			if(this.$owlItems.length > this.options.items){
				$('.vt-slider6 .navslider').show();
			}else{
				$('.vt-slider6 .navslider').hide();
			}
		}
		//scrollPerPage: true,
	});
	$('.vt-slider6 .navslider .prev').on('click', function(e){
		e.preventDefault();
		$('.vt-slider6 div.products-grid').trigger('owl.prev');
	});
	$('.vt-slider6 .navslider .next').on('click', function(e){
		e.preventDefault();
		$('.vt-slider6 div.products-grid').trigger('owl.next');
	});
     /* detail */
	$('.product-options-bottom .size ul li').click(function(){
	$('.price-info .price-box .price').text($(this).attr('add'));
	$('.product-options-bottom .size ul li').removeClass('actived');
	$(this).addClass('actived');
	});
	$('.product-options-bottom .color ul li').click(function(){
	$('.price-info .price-box .price').text($(this).attr('add'));
	$('.product-options-bottom .color ul li').removeClass('actived');
	$(this).addClass('actived');
	});
	  $('#galary-image .item .sub-item img').click(function(){
		$('.image-main img').attr('src',$(this).attr('src'));
		});
		$('.click-quick-view').click(function(){
		$('.image-quick-view .content img').attr('src',$('.image-main img').attr('src'));
		$('.image-quick-view').toggleClass('no-display');
		});
		$('.image-quick-view .content span').click(function(){
		$('.image-quick-view').toggleClass('no-display');
		});
	  $('.lastest-slider div.products-grid').owlCarousel({
		items: 1,
		itemsCustom: [ 
			[0, 1], 
			[480, 1], 
			[768, 1], 
			[992,1], 
			[1200,1] 
		],
		pagination: true,
		slideSpeed : 800,
		addClassActive: true,
		//scrollPerPage: true,
	});
	
	/* grid,list */
		
				$('#tab1').click(function(){
					if($(this).hasClass('accordion-open')){
						$(this).removeClass('accordion-open');
						$(this).addClass('accordion-close');
					}else{
						$(this).removeClass('accordion-close');
						$(this).addClass('accordion-open');
					}                            
					$('.tabcontent1').slideToggle();
				});
				
				$('#tab11').click(function(){
					if($(this).hasClass('accordion-open')){
						$(this).removeClass('accordion-open');
						$(this).addClass('accordion-close');
					}else{
						$(this).removeClass('accordion-close');
						$(this).addClass('accordion-open');
					}                            
					$('.tabcontent11').slideToggle();
				});
				
				$('#tab12').click(function(){
					if($(this).hasClass('accordion-open')){
						$(this).removeClass('accordion-open');
						$(this).addClass('accordion-close');
					}else{
						$(this).removeClass('accordion-close');
						$(this).addClass('accordion-open');
					}                            
					$('.tabcontent12').slideToggle();
				});
				
				$('#tab13').click(function(){
					if($(this).hasClass('accordion-open')){
						$(this).removeClass('accordion-open');
						$(this).addClass('accordion-close');
					}else{
						$(this).removeClass('accordion-close');
						$(this).addClass('accordion-open');
					}                            
					$('.tabcontent13').slideToggle();
				});
				
					$('#tab2').click(function(){
						if($(this).hasClass('accordion-open')){
							$(this).removeClass('accordion-open');
							$(this).addClass('accordion-close');
						}else{
							$(this).removeClass('accordion-close');
							$(this).addClass('accordion-open');
						}                            
						$('.tabcontent2').slideToggle();
					});
					
				$('#tab4').click(function(){
					if($(this).hasClass('accordion-open')){
						$(this).removeClass('accordion-open');
						$(this).addClass('accordion-close');
					}else{
						$(this).removeClass('accordion-close');
						$(this).addClass('accordion-open');
					}                            
					$('.tabcontent4').slideToggle();
				});
				
				$('#tab3').click(function(){
							if($(this).hasClass('accordion-open')){
								$(this).removeClass('accordion-open');
								$(this).addClass('accordion-close');
							}else{
								$(this).removeClass('accordion-close');
								$(this).addClass('accordion-open');
							}                            
							$('.tabcontent3').slideToggle();
						});
					
					$('#tab5').click(function(){
						if($(this).hasClass('accordion-open')){
							$(this).removeClass('accordion-open');
							$(this).addClass('accordion-close');
						}else{
							$(this).removeClass('accordion-close');
							$(this).addClass('accordion-open');
						}                            
						$('.tabcontent5').slideToggle();
					});
				
					jQuery('.toolbar-top .selected-order').html(jQuery('.toolbar-top .select-order li .selected').html());
					jQuery('.toolbar-top .selected-limiter').html(jQuery('.toolbar-top .select-limiter li .selected').html());
					 jQuery('.toolbar-top .selected-limiter').click(function(){
					  jQuery('.toolbar-top .select-limiter').toggleClass('current-item');
					  });
					  
					  jQuery('.toolbar-top .select-limiter li').click(function(){
					  jQuery('.toolbar-top .selected-limiter').html(jQuery(this).html());
					  });
					  
					  jQuery('.toolbar-top .selected-order').click(function(){
					  jQuery('.toolbar-top .select-order').toggleClass('current-item');
					   });
					   
					   jQuery('.toolbar-top .select-order li').click(function(){
					  jQuery('.toolbar-top .selected-order').html(jQuery(this).html());
					  });
				
					jQuery('.toolbar-bottom .selected-order').html(jQuery('.toolbar-bottom .select-order li .selected').html());
						jQuery('.toolbar-bottom .selected-limiter').html(jQuery('.toolbar-bottom .select-limiter li .selected').html());
						 jQuery('.toolbar-bottom .selected-limiter').click(function(){
						  jQuery('.toolbar-bottom .select-limiter').toggleClass('current-item');
						  });
						  
						  jQuery('.toolbar-bottom .select-limiter li').click(function(){
						  jQuery('.toolbar-bottom .selected-limiter').html(jQuery(this).html());
						  });
						  
						  jQuery('.toolbar-bottom .selected-order').click(function(){
						  jQuery('.toolbar-bottom .select-order').toggleClass('current-item');
						   });
						   
						   jQuery('.toolbar-bottom .select-order li').click(function(){
						  jQuery('.toolbar-bottom .selected-order').html(jQuery(this).html());
						  });
	});
})(jQuery); // End of use strict